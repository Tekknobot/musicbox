using System;
using System.Collections.Generic;
using UnityEngine;

/* ****************
   * Sample Usage *
   ****************
  // prerequisite : put a gameobject with the ADSR script on it in your scene
  // this enables the update loop that transparently updates Envelope objects
 
  // init-time
  var e1 = new Envelope
  {
    A = { Target = 1, Duration = 2, Out = EasingType.Exponential },
    S = { Duration = 0.5 },
    R = { Duration = 3, In = EasingType.Exponential, Out = EasingType.Exponential },
  };
  var e2 = new Envelope(e1)
  {
    P = { Duration = 0.1 }
  };
  // when events occur
  e1.Trigger();
  
  // mapping the modulated value to a thing (implicit cast to float)
  someMaterial.SetFloat("_ShaderParam", e1);
*/

public class ADSR : MonoBehaviour
{
    public static ADSR Instance { get; private set; }

    readonly List<Envelope> envelopes = new List<Envelope>();

    void Start()
    {
        if (Instance) throw new InvalidOperationException("Two ADSR objects in scene!");
        Instance = this;
    }
    void OnDestroy()
    {
        if (Instance != this) throw new InvalidOperationException("wat");
        Instance = null;
    }

    void Update()
    {
        foreach (var e in envelopes)
            e.Update();
    }

    public void RegisterEnvelope(Envelope e)
    {
        envelopes.Add(e);
    }
    public void UnregisterEnvelope(Envelope e)
    {
        envelopes.Remove(e);
    }
}

public class FlatEnvelopePhase
{
    public double Duration;

    public FlatEnvelopePhase() { }
    public FlatEnvelopePhase(FlatEnvelopePhase other)
    {
        Duration = other.Duration;
    }
}

public class EnvelopePhase
{
    public double Duration;
    public double Target;
    public EasingType In = EasingType.Linear;
    public EasingType Out = EasingType.Linear;

    public EnvelopePhase() { }
    public EnvelopePhase(EnvelopePhase other)
    {
        Duration = other.Duration;
        Target = other.Target;
        In = other.In;
        Out = other.Out;
    }

    public float Ease(float step) 
    {
        if (In == EasingType.Linear)    return EasingFunction.EaseOut(step, Out);
        if (Out == EasingType.Linear)   return EasingFunction.EaseIn(step, In);
        return EasingFunction.EaseInOut(step, In, Out);
    }
}

public class Envelope
{
    float current;
    float? sinceTriggered;
    float? sinceReleased;

    public FlatEnvelopePhase P { get; private set; }
    public EnvelopePhase A { get; private set; }
    public EnvelopePhase D { get; private set; }
    public FlatEnvelopePhase S { get; private set; }

    // R.Target is ignored, assumed to be 0
    public EnvelopePhase R { get; private set; }

    public Envelope()
    {
        P = new FlatEnvelopePhase();
        A = new EnvelopePhase();
        D = new EnvelopePhase();
        S = new FlatEnvelopePhase();
        R = new EnvelopePhase();

        ADSR.Instance.RegisterEnvelope(this);
    }
    public Envelope(Envelope other)
    {
        P = new FlatEnvelopePhase(other.P);
        A = new EnvelopePhase(other.A);
        D = new EnvelopePhase(other.D);
        S = new FlatEnvelopePhase(other.S);
        R = new EnvelopePhase(other.R);

        ADSR.Instance.RegisterEnvelope(this);
    }
    ~Envelope()
    {
        ADSR.Instance.UnregisterEnvelope(this);
    }

    public void Trigger(float? scheduleReleaseIn = null)
    {
        sinceTriggered = 0;
        sinceReleased = scheduleReleaseIn.HasValue ? (float?) -scheduleReleaseIn.Value : null;
    }

    public void Release()
    {
        sinceReleased = 0;
        sinceTriggered = null;
    }

    public static implicit operator float(Envelope d)
    {
        return d.current;
    }

    internal void Update()
    {
        if (sinceTriggered == null && sinceReleased == null)
        {
            current = 0;
            return;
        }

        if (sinceReleased != null)
        {
            bool wasNegative = sinceReleased < 0;
            sinceReleased += Time.deltaTime;

            if (sinceReleased > 0)
            {
                if (wasNegative)
                    Release();

                float step = Mathf.Clamp01(sinceReleased.Value / (float) R.Duration);
                current = Mathf.Lerp((float) (D.Duration == 0 ? A.Target : D.Target), 0, R.Ease(step));

                if (step >= 1)
                {
                    current = 0;
                    sinceReleased = null;
                }                
            }
        }

        if (sinceTriggered != null)
        {
            sinceTriggered += Time.deltaTime;

            float t = sinceTriggered.Value;
            float aStep = Mathf.Clamp01((t -= (float) P.Duration) / (float) A.Duration);
            float dStep = Mathf.Clamp01((t -= (float) A.Duration) / (float) D.Duration);
            float sStep = Mathf.Clamp01((t -= (float) D.Duration) / (float) S.Duration);

            if (aStep < 1)
                current = Mathf.Lerp(0, (float) A.Target, A.Ease(aStep));
            else if (dStep < 1)
                current = Mathf.Lerp((float) A.Target, (float) D.Target, D.Ease(dStep));
            else if (sStep < 1)
                current = (float) (D.Duration == 0 ? A.Target : D.Target);
            else
                Release();
        }
    }
}
