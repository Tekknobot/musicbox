using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Oscillator : MonoBehaviour {
    public float frequency = 440.0f;
    private double increment;
    private double FMfreq;
    private double phase;
    private double sampling_frequency = 48000.0;
    
    public float gain = 0.1f;
    public float volume = 0.1f;

    public float[] frequencies;

    public Button octaveOne;
    public Button octaveTwo;
    public Button octaveThree;

    public Button sineWave;
    public Button squareWave;
    public Button triangleWave;   

    public Toggle legatoButton;
    
    public bool legatoActive = false;

    public int octaveDownInt = -12;
    public int octaveUpInt = 12;

    public GameObject NoteManagerLow;
    public GameObject NoteManagerMid;
    public GameObject NoteManagerHigh;    

    [Range(1, 10)]
    public float pitch;  

    [Range(0, 30)]
    public float frequency2;
    [Range(0, 0.1f)]
    public float gain2;      

    [Range(0, 1f)]
    public float noteLength;       

    public bool sine;
    public bool square;
    public bool triangle;

    public bool low;
    public bool mid;
    public bool high;   

    public int timeIndex = 0; 

	public float bpm;
	public float ms;
	public float nextbeatTime;
	public float timeSinceLevelLoad;
    public float step;
	public GameObject Pad1;

    void Start() {
        Pad1 = GameObject.Find("Pad 1");      

        gain = 0f;
        sine = true;
        low = true;

		octaveOne.GetComponent<Button>().onClick.AddListener(OctaveOneOnClick); 
		octaveTwo.GetComponent<Button>().onClick.AddListener(OctaveTwoOnClick);
		octaveThree.GetComponent<Button>().onClick.AddListener(OctaveThreeOnClick);  

        ////

		sineWave.onClick.AddListener(SineOnClick); 
		squareWave.onClick.AddListener(SquareOnClick);
		triangleWave.onClick.AddListener(TriangleOnClick); 

        ////


        ColorBlock colors = sineWave.colors;
        colors.normalColor = new Color32(200, 200, 200, 255);
        sineWave.colors = colors;
        
        octaveOne.Select();
        
        frequencies = new float[48];
        frequencies[0] = 130.81f;   // C3
        frequencies[1] = 138.59f;   // C#3
        frequencies[2] = 146.83f;   // D3 
        frequencies[3] = 155.56f;   // D#3
        frequencies[4] = 164.81f;   // E3                      
        frequencies[5] = 174.61f;   // F3
        frequencies[6] = 185.00f;   // F#3
        frequencies[7] = 196.00f;   // G3
        frequencies[8] = 207.65f;   // G#3
        frequencies[9] = 220.00f;   // A3
        frequencies[10] = 233.08f;  // A#3
        frequencies[11] = 246.94f;  // B3
        frequencies[12] = 261.63f;  // C4                        
        frequencies[13] = 277.18f;  // C#4
        frequencies[14] = 293.66f;  // D4
        frequencies[15] = 311.13f;  // D#4  

        frequencies[16] = 329.63f;   // E4 
        frequencies[17] = 349.23f;   // F4
        frequencies[18] = 369.99f;   // F#4
        frequencies[19] = 392.00f;   // G4
        frequencies[20] = 415.30f;   // G#4                      
        frequencies[21] = 440.00f;   // A4
        frequencies[22] = 466.16f;   // A#4
        frequencies[23] = 493.88f;   // B4
        frequencies[24] = 523.25f;   // C5
        frequencies[25] = 554.37f;   // C#5
        frequencies[26] = 587.33f;   // D5
        frequencies[27] = 622.25f;   // D#5
        frequencies[28] = 659.25f;   // E5                       
        frequencies[29] = 698.46f;   // F5
        frequencies[30] = 739.99f;   // F#5
        frequencies[31] = 783.99f;   // G5

        frequencies[32] = 830.61f;   // G#5
        frequencies[33] = 880.00f;   // A5
        frequencies[34] = 932.33f;   // A#5 
        frequencies[35] = 987.77f;   // B5
        frequencies[36] = 1046.50f;  // C6                       
        frequencies[37] = 1108.73f;  // C#6 
        frequencies[38] = 1174.66f;  // D6 
        frequencies[39] = 1244.51f;  // D#6 
        frequencies[40] = 1318.51f;  // E6 
        frequencies[41] = 1396.91f;  // F6 
        frequencies[42] = 1479.98f;  // F#6
        frequencies[43] = 1567.98f;  // G6
        frequencies[44] = 1661.22f;  // G#6                        
        frequencies[45] = 1760.00f;  // A6
        frequencies[46] = 1864.66f;  // A#6
        frequencies[47] = 1975.53f;  // B6        

        StartCoroutine(DefaultNotes());      
    }

    void Update() {
        Pad1 = GameObject.Find("Pad 1");

        bpm = Pad1.GetComponent<OperatorTile>().bpm;
        ms = Pad1.GetComponent<OperatorTile>().ms;
        nextbeatTime = Pad1.GetComponent<OperatorTile>().nextbeatTime;
        timeSinceLevelLoad = Pad1.GetComponent<OperatorTile>().timeSinceLevelLoad;
        step = nextbeatTime - timeSinceLevelLoad;

		if (gameObject.name == "SynthPads") {
			gameObject.GetComponent<Oscillator>().pitch = GameObject.Find("Pitch").GetComponent<Slider>().value;			
		}	

        if (low == true) { 
            octaveOne.Select(); 
        }
        else if (mid == true) {
            octaveTwo.Select();       
        }    
        else if (high == true) {
            octaveThree.Select();         
        } 

        LegatoSwitch(); 
    }

    void LegatoSwitch() {
        if (legatoButton.GetComponent<Toggle>().isOn == true) {
            if (gameObject.name != "SynthPads") {
                StartCoroutine(MuteNote());         
            }
        }     
        else {
            return;
        }          
    }

	void OctaveOneOnClick(){      
        NoteManagerLow.SetActive(true);
        NoteManagerMid.SetActive(false);
        NoteManagerHigh.SetActive(false);  
        low = true;
        mid = false;
        high = false;              
	}

	void OctaveTwoOnClick(){   
        NoteManagerLow.SetActive(false);
        NoteManagerMid.SetActive(true);
        NoteManagerHigh.SetActive(false);    
        low = false;
        mid = true;
        high = false;                         
	}

	void OctaveThreeOnClick(){   
        NoteManagerLow.SetActive(false);
        NoteManagerMid.SetActive(false);
        NoteManagerHigh.SetActive(true);    
        low = false;
        mid = false;
        high = true;                   
	}    

	void SineOnClick(){      
        sine = true;
        square = false;
        triangle = false;

        ColorBlock colorsSine = sineWave.colors;
        colorsSine.normalColor = new Color32(200, 200, 200, 255);
        sineWave.colors = colorsSine;   

        ColorBlock colorsSquare = squareWave.colors;
        colorsSquare.normalColor = new Color32(245, 0, 84, 255);
        squareWave.colors = colorsSquare;       

        ColorBlock colorsTriangle = triangleWave.colors;
        colorsTriangle.normalColor = new Color32(245, 0, 84, 255);
        triangleWave.colors = colorsTriangle; 
	}

	void SquareOnClick(){   
        sine = false;
        square = true;
        triangle = false;        

        ColorBlock colorsSine = sineWave.colors;
        colorsSine.normalColor = new Color32(245, 0, 84, 255);
        sineWave.colors = colorsSine;   

        ColorBlock colorsSquare = squareWave.colors;
        colorsSquare.normalColor = new Color32(200, 200, 200, 255);
        squareWave.colors = colorsSquare;       

        ColorBlock colorsTriangle = triangleWave.colors;
        colorsTriangle.normalColor = new Color32(245, 0, 84, 255);
        triangleWave.colors = colorsTriangle;                
	}

	void TriangleOnClick(){   
        sine = false;
        square = false;
        triangle = true;     

        ColorBlock colorsSine = sineWave.colors;
        colorsSine.normalColor = new Color32(245, 0, 84, 255);
        sineWave.colors = colorsSine;   

        ColorBlock colorsSquare = squareWave.colors;
        colorsSquare.normalColor = new Color32(245, 0, 84, 255);
        squareWave.colors = colorsSquare;       

        ColorBlock colorsTriangle = triangleWave.colors;
        colorsTriangle.normalColor = new Color32(200, 200, 200, 255);
        triangleWave.colors = colorsTriangle;  
	}  

	void LegatoOnClick(){   
        legatoActive = true;
	}      

    void OnAudioFilterRead(float[] data, int channels) {
        increment = (frequency * 2.0 * Mathf.PI / sampling_frequency);
        
        if (sine == true) { 
            for (int i = 0; i < data.Length; i += channels) {
                phase += increment;
                
                //sine
                data[i] = (float)(gain * Mathf.Sin((float)phase * pitch));

                if (channels == 2) {
                    data[i + 1] = data[i];
                }

                if (phase > (Mathf.PI * 2)) {
                    phase = 0.0;
                }
            }
        }

        else if (square == true) {
            for (int i = 0; i < data.Length; i += channels) {
                phase += increment;

                //sqaure
                if (gain * Mathf.Sin((float)phase * pitch) >= 0 * gain) {
                    data[i] = (float)gain * 0.6f;
                }
                else {
                    data[i] = (-(float)gain) * 0.6f;
                }

                if (channels == 2) {
                    data[i + 1] = data[i];
                }

                if (phase > (Mathf.PI * 2)) {
                    phase = 0.0;
                }
            }            
        }    
        else if (triangle == true) {
            for (int i = 0; i < data.Length; i += channels) {
                phase += increment;

                //triangle
                data[i] = (float)(gain * (double)Mathf.PingPong((float)phase * pitch, 1.0f));

                if (channels == 2) {
                    data[i + 1] = data[i];
                }

                if (phase > (Mathf.PI * 2)) {
                    phase = 0.0;
                }
            }            
        }
    }    

    IEnumerator DefaultNotes() {      
        yield return new WaitForSeconds(0.05f);
        NoteManagerLow.SetActive(true);
        NoteManagerMid.SetActive(false);
        NoteManagerHigh.SetActive(false); 
    }    

    IEnumerator MuteNote() {      
        yield return new WaitForSeconds(noteLength);
        gain = 0f;
    }      
}      