using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class OperatorTile : MonoBehaviour {
	public static OperatorTile instance;

	private static Color selectedColor = new Color(.5f, .5f, .5f, 1.0f);
	private static OperatorTile previousSelected = null;

	private Vector2[] adjacentDirections = new Vector2[] { Vector2.up, Vector2.down, Vector2.left, Vector2.right };

	public SpriteRenderer render;
	public GameObject whiteParticles;

	public bool isSelected = false;

	Camera mainCamera;

	public GameObject clickedPad;

	public Sprite block;
	public Sprite blue;
	public Sprite green;
	public Sprite orange;
	public Sprite pink;
	public Sprite purple;
	public Sprite red;
	public Sprite turquoise;
	public Sprite yellow;

	public Sprite Note_0;
	public Sprite Note_1;
	public Sprite Note_2;
	public Sprite Note_3;
	public Sprite Note_4;
	public Sprite Note_5;
	public Sprite Note_6;
	public Sprite Note_7;
	public Sprite Note_8;
	public Sprite Note_9;
	public Sprite Note_10;
	public Sprite Note_11;
	public Sprite Note_12;
	public Sprite Note_13;
	public Sprite Note_14;
	public Sprite Note_15;	

	public Sprite Note_16;
	public Sprite Note_17;
	public Sprite Note_18;
	public Sprite Note_19;
	public Sprite Note_20;
	public Sprite Note_21;
	public Sprite Note_22;
	public Sprite Note_23;
	public Sprite Note_24;
	public Sprite Note_25;
	public Sprite Note_26;
	public Sprite Note_27;
	public Sprite Note_28;
	public Sprite Note_29;
	public Sprite Note_30;
	public Sprite Note_31;

	public Sprite Note_32;
	public Sprite Note_33;
	public Sprite Note_34;
	public Sprite Note_35;
	public Sprite Note_36;
	public Sprite Note_37;
	public Sprite Note_38;
	public Sprite Note_39;
	public Sprite Note_40;
	public Sprite Note_41;
	public Sprite Note_42;
	public Sprite Note_43;
	public Sprite Note_44;
	public Sprite Note_45;
	public Sprite Note_46;
	public Sprite Note_47;	

	public Sprite Note_48;
	public Sprite Note_49;
	public Sprite Note_50;
	public Sprite Note_51;
	public Sprite Note_52;
	public Sprite Note_53;
	public Sprite Note_54;
	public Sprite Note_55;
	public Sprite Note_56;
	public Sprite Note_57;
	public Sprite Note_58;
	public Sprite Note_59;
	public Sprite Note_60;
	public Sprite Note_61;
	public Sprite Note_62;
	public Sprite Note_63;	

	public Sprite sample0;
	public Sprite sample1;
	public Sprite sample2;
	public Sprite sample3;
	public Sprite sample4;
	public Sprite sample5;
	public Sprite sample6;
	public Sprite sample7;
	public Sprite sample8;
	public Sprite sample9;
	public Sprite sample10;
	public Sprite sample11;
	public Sprite sample12;
	public Sprite sample13;
	public Sprite sample14;
	public Sprite sample15;

	int jFound;
	int kFound;

	private AudioSource audioSource;
	private AudioSource audioSourceChops;
	
	public AudioClip[] samples;
	public AudioClip[] chops;
	private AudioClip sampleClip;

	private AudioSource audioSourceOnTile;

	public AudioSource audioSource0;
	public AudioSource audioSource1;
	public AudioSource audioSource2;
	public AudioSource audioSource3;
	public AudioSource audioSource4;
	public AudioSource audioSource5;
	public AudioSource audioSource6;
	public AudioSource audioSource7;

	public AudioSource chopSource;

	public float bpm;
	public float ms;
	public float nextbeatTime;
	public float timeSinceLevelLoad;

	private float kickVolume = 1f;
	private float snareVolume = 1f;
	private float cHatVolume = 1f;
	private float oHatVolume = 1f;
	private float clapVolume = 1f;
	private float crashVolume = 1f;
	private float rideVolume = 1f;
	private float rimVolume = 1f;
	private float chopsVolume = 1f;
	private float synthVolume = 1f;

	public SpriteRenderer[,] blockTiles;
	public SpriteRenderer[,] padTiles;
	public SpriteRenderer[,] noteTilesLow;
	public SpriteRenderer[,] noteTilesMid;
	public SpriteRenderer[,] noteTilesHigh;
	public SpriteRenderer[,] noteTilesSub;

	bool hasCoroutineStarted = false;

	private MusicPlayer player;

	GameObject SynthSource_0;
	GameObject SynthSource_1;
	GameObject SynthSource_2;
	GameObject SynthSource_3;
    GameObject SynthSource_4;
	GameObject SynthSource_5;
	GameObject SynthSource_6;
	GameObject SynthSource_7;
	GameObject SynthSource_8;
	GameObject SynthSource_9;
	GameObject SynthSource_10;
	GameObject SynthSource_11;
	GameObject SynthSource_12;
	GameObject SynthSource_13;
	GameObject SynthSource_14;
	GameObject SynthSource_15;

	GameObject SynthSource_16;
	GameObject SynthSource_17;
	GameObject SynthSource_18;
	GameObject SynthSource_19;
	GameObject SynthSource_20;
	GameObject SynthSource_21;
	GameObject SynthSource_22;
	GameObject SynthSource_23;
	GameObject SynthSource_24;
	GameObject SynthSource_25;
	GameObject SynthSource_26;
	GameObject SynthSource_27;
	GameObject SynthSource_28;
	GameObject SynthSource_29;
	GameObject SynthSource_30;
	GameObject SynthSource_31;

	GameObject SynthSource_32;
	GameObject SynthSource_33;
	GameObject SynthSource_34;
	GameObject SynthSource_35;
	GameObject SynthSource_36;
	GameObject SynthSource_37;
	GameObject SynthSource_38;
	GameObject SynthSource_39;
	GameObject SynthSource_40;
	GameObject SynthSource_41;
	GameObject SynthSource_42;
	GameObject SynthSource_43;
	GameObject SynthSource_44;
	GameObject SynthSource_45;
	GameObject SynthSource_46;
	GameObject SynthSource_47;

	GameObject SynthSource_48;
	GameObject SynthSource_49;
	GameObject SynthSource_50;
	GameObject SynthSource_51;
	GameObject SynthSource_52;
	GameObject SynthSource_53;
	GameObject SynthSource_54;
	GameObject SynthSource_55;
	GameObject SynthSource_56;
	GameObject SynthSource_57;
	GameObject SynthSource_58;
	GameObject SynthSource_59;
	GameObject SynthSource_60;
	GameObject SynthSource_61;
	GameObject SynthSource_62;
	GameObject SynthSource_63;	

	public GameObject Oscillator1;
	public GameObject Oscillator2;
	public GameObject Oscillator3;


	public GameObject[] SynthVols;
	public GameObject[] gain2s;

	private float gain2;
	private float delay;
	private float wetMix;
	private float pitch;


	public int stepCount;
	public GameObject legatoButton;

	Dictionary<string, int> spriteClip = new Dictionary<string, int>() {
		{ "blue 0", 0 },
		{ "green  0", 1 },
		{ "orange 0", 2 },
		{ "pink 0", 3 },
		{ "purple 0", 4 },
		{ "red 0", 5 },
		{ "turquoise  0", 6 },
		{ "yellow  0", 7 },
	};

	Dictionary<string, int> chopClip = new Dictionary<string, int>() {
		{ "sample 0", 0 },
		{ "sample 1", 1 },
		{ "sample 2", 2 },
		{ "sample 3", 3 },
		{ "sample 4", 4 },
		{ "sample 5", 5 },
		{ "sample 6", 6 },
		{ "sample 7", 7 },
		{ "sample 8", 8 },
		{ "sample 9", 9 },
		{ "sample 10", 10 },
		{ "sample 11", 11 },
		{ "sample 12", 12 },
		{ "sample 13", 13 },
		{ "sample 14", 14 },
		{ "sample 15", 15 },
	};

	void Awake() {
		if (GameObject.FindGameObjectsWithTag("MusicPlayer").Length > 1) Destroy(GameObject.FindGameObjectWithTag("MusicPlayer"));
		player =  GameObject.Find("MusicPlayer").GetComponent<MusicPlayer>();
		render = GetComponent<SpriteRenderer>();
		mainCamera = Camera.main;
		Deselect();
    }

	void Start() {
		audioSource = SEQAudioManager.instance.GetComponent<AudioSource>();
		audioSourceChops = GameObject.Find("Spectrum").GetComponent<AudioSource>();
		audioSourceOnTile = gameObject.GetComponent<AudioSource>();

		bpm = GameObject.Find("Slider").GetComponent<Slider>().value;

		legatoButton = GameObject.Find("Legato");

		SynthSource_0 = GameObject.Find("C3");
		SynthSource_1 = GameObject.Find("C#3");
		SynthSource_2 = GameObject.Find("D3");
		SynthSource_3 = GameObject.Find("D#3");
		SynthSource_4 = GameObject.Find("E3");	
		SynthSource_5 = GameObject.Find("F3");
		SynthSource_6 = GameObject.Find("F#3");
		SynthSource_7 = GameObject.Find("G3");
		SynthSource_8 = GameObject.Find("G#3");
		SynthSource_9 = GameObject.Find("A3");
		SynthSource_10 = GameObject.Find("A#3");
		SynthSource_11 = GameObject.Find("B3");
		SynthSource_12 = GameObject.Find("C4");
		SynthSource_13 = GameObject.Find("C#4");
		SynthSource_14 = GameObject.Find("D4");
		SynthSource_15 = GameObject.Find("D#4");

		SynthSource_16 = GameObject.Find("E4");
		SynthSource_17 = GameObject.Find("F4");
		SynthSource_18 = GameObject.Find("F#4");
		SynthSource_19 = GameObject.Find("G4");
		SynthSource_20 = GameObject.Find("G#4");	
		SynthSource_21 = GameObject.Find("A4");
		SynthSource_22 = GameObject.Find("A#4");
		SynthSource_23 = GameObject.Find("B4");
		SynthSource_24 = GameObject.Find("C5");
		SynthSource_25 = GameObject.Find("C#5");
		SynthSource_26 = GameObject.Find("D5");
		SynthSource_27 = GameObject.Find("D#5");
		SynthSource_28 = GameObject.Find("E5");
		SynthSource_29 = GameObject.Find("F5");
		SynthSource_30 = GameObject.Find("F#5");
		SynthSource_31 = GameObject.Find("G5");		

		SynthSource_32 = GameObject.Find("G#5");
		SynthSource_33 = GameObject.Find("A5");
		SynthSource_34 = GameObject.Find("A#5");
		SynthSource_35 = GameObject.Find("B5");
		SynthSource_36 = GameObject.Find("C6");	
		SynthSource_37 = GameObject.Find("C#6");
		SynthSource_38 = GameObject.Find("D6");
		SynthSource_39 = GameObject.Find("D#6");
		SynthSource_40 = GameObject.Find("E6");
		SynthSource_41 = GameObject.Find("F6");
		SynthSource_42 = GameObject.Find("F#6");
		SynthSource_43 = GameObject.Find("G6");
		SynthSource_44 = GameObject.Find("G#6");
		SynthSource_45 = GameObject.Find("A6");
		SynthSource_46 = GameObject.Find("A#6");
		SynthSource_47 = GameObject.Find("B6");	

		SynthSource_48 = GameObject.Find("G#1");
		SynthSource_49 = GameObject.Find("A1");
		SynthSource_50 = GameObject.Find("A#1");
		SynthSource_51 = GameObject.Find("B1");
		SynthSource_52 = GameObject.Find("C2");	
		SynthSource_53 = GameObject.Find("C#2");
		SynthSource_54 = GameObject.Find("D2");
		SynthSource_55 = GameObject.Find("D#2");
		SynthSource_56 = GameObject.Find("E2");
		SynthSource_57 = GameObject.Find("F2");
		SynthSource_58 = GameObject.Find("F#2");
		SynthSource_59 = GameObject.Find("G2");
		SynthSource_60 = GameObject.Find("G#2");
		SynthSource_61 = GameObject.Find("A2");
		SynthSource_62 = GameObject.Find("A#2");
		SynthSource_63 = GameObject.Find("B2");						

		Oscillator1 = GameObject.Find("Oscillator1");
		Oscillator2 = GameObject.Find("Oscillator2");		
		Oscillator3 = GameObject.Find("Oscillator3");

		blockTiles = new SpriteRenderer[OperatorManager.instance.xSize, OperatorManager.instance.ySize];
		for (int y = 0; y < OperatorManager.instance.ySize; y++) {
			for (int x = 0; x < OperatorManager.instance.xSize; x++) {
				blockTiles[x,y] = OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>();
			}
		}

		padTiles = new SpriteRenderer[PadManager.instance.xSize, PadManager.instance.ySize];
		for (int y = 0; y < PadManager.instance.ySize; y++) {
			for (int x = 0; x < PadManager.instance.xSize; x++) {
				padTiles[x,y] = PadManager.instance.tiles[x, y].GetComponent<SpriteRenderer>();
			}
		}

		noteTilesLow = new SpriteRenderer[NoteManagerLow.instance.xSize, NoteManagerLow.instance.ySize];
		for (int y = 0; y < NoteManagerLow.instance.ySize; y++) {
			for (int x = 0; x < NoteManagerLow.instance.xSize; x++) {
				noteTilesLow[x,y] = NoteManagerLow.instance.tiles[x, y].GetComponent<SpriteRenderer>();
			}
		}	

		noteTilesMid = new SpriteRenderer[NoteManagerMid.instance.xSize, NoteManagerMid.instance.ySize];
		for (int y = 0; y < NoteManagerMid.instance.ySize; y++) {
			for (int x = 0; x < NoteManagerMid.instance.xSize; x++) {
				noteTilesMid[x,y] = NoteManagerMid.instance.tiles[x, y].GetComponent<SpriteRenderer>();
			}
		}

		noteTilesHigh = new SpriteRenderer[NoteManagerHigh.instance.xSize, NoteManagerHigh.instance.ySize];
		for (int y = 0; y < NoteManagerHigh.instance.ySize; y++) {
			for (int x = 0; x < NoteManagerHigh.instance.xSize; x++) {
				noteTilesHigh[x,y] = NoteManagerHigh.instance.tiles[x, y].GetComponent<SpriteRenderer>();
			}
		}	

		noteTilesSub = new SpriteRenderer[NoteManagerSub.instance.xSize, NoteManagerSub.instance.ySize];
		for (int y = 0; y < NoteManagerSub.instance.ySize; y++) {
			for (int x = 0; x < NoteManagerSub.instance.xSize; x++) {
				noteTilesSub[x,y] = NoteManagerSub.instance.tiles[x, y].GetComponent<SpriteRenderer>();
			}
		}						

		StartCoroutine(TriggerWave());
    }

	void Update() {
		timeSinceLevelLoad = Time.timeSinceLevelLoad;
		ms = 60 / bpm / 4;
		
		if (GameObject.Find ("Slider")) {
			bpm = GameObject.Find ("Slider").GetComponent<Slider>().value;
		}
		if (GameObject.Find ("BPM")) {
			GameObject.Find ("BPM").GetComponent<Text>().text = bpm.ToString();
		}	

		if (GameObject.Find ("Kick")) {		
			kickVolume = GameObject.Find ("Kick").GetComponent<Slider>().value;
			audioSource0.volume = kickVolume;
		}	

		if (GameObject.Find ("Snare")) {	
			snareVolume = GameObject.Find ("Snare").GetComponent<Slider>().value;
			audioSource1.volume = snareVolume;
		}	

		if (GameObject.Find ("CHat")) {	
			cHatVolume = GameObject.Find ("CHat").GetComponent<Slider>().value;
			audioSource2.volume = cHatVolume;
		}

		if (GameObject.Find ("OHat")) {
			oHatVolume = GameObject.Find ("OHat").GetComponent<Slider>().value;
			audioSource3.volume = oHatVolume;
		}

		if (GameObject.Find ("Clap")) {
			clapVolume = GameObject.Find ("Clap").GetComponent<Slider>().value;
			audioSource4.volume = clapVolume;
		}	

		if (GameObject.Find ("Crash")) {
			crashVolume = GameObject.Find ("Crash").GetComponent<Slider>().value;
			audioSource5.volume = crashVolume;
		}

		if (GameObject.Find ("Ride")) {
			rideVolume = GameObject.Find ("Ride").GetComponent<Slider>().value;
			audioSource6.volume = rideVolume;
		}	

		if (GameObject.Find ("Rim")) {
			rimVolume = GameObject.Find ("Rim").GetComponent<Slider>().value;
			audioSource7.volume = rimVolume;
		}

		if (GameObject.Find ("SampleSlider") && audioSourceChops != null) {
			chopsVolume = GameObject.Find ("SampleSlider").GetComponent<Slider>().value;
			audioSourceChops.volume = chopsVolume;
		}	

		if (GameObject.Find ("SynthVol")) {
			synthVolume = GameObject.Find ("SynthVol").GetComponent<Slider>().value;			
		}

		if (GameObject.Find ("Pitch")) {
			pitch = GameObject.Find ("Pitch").GetComponent<Slider>().value;			
		}	

		if (GameObject.Find ("Gain2")) {
			gain2 = GameObject.Find ("Gain2").GetComponent<Slider>().value;		
		}

		if (GameObject.Find ("Delay")) {
			delay = Oscillator1.GetComponent<AudioEchoFilter>().delay;			
		}	

		if (GameObject.Find ("WetMix")) {
			wetMix = Oscillator1.GetComponent<AudioEchoFilter>().wetMix;		
		}
	}

	private void Select() {
		if (render.sprite.name != "block 0") {
			DisplayActiveBoard();
		}
		else {
			return;
		}

		previousSelected = GetComponent<OperatorTile>();

		if (spriteClip.ContainsKey(render.sprite.name)) {
			sampleClip = samples[spriteClip[render.sprite.name]];
			audioSource.clip = sampleClip;
			audioSource.Play();
			render.color = selectedColor;
		}								

		//Chops
		if (render.sprite.name == "sample 0" && player.chopTime.Count > 16) {
			audioSourceChops.clip = player.song[0];
			audioSourceChops.time = player.chopTime[0];
			audioSourceChops.Play();
			audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[1]-player.chopTime[0]));
			render.color = selectedColor;					
		}

		if (render.sprite.name == "sample 1" && player.chopTime.Count > 16) {
			audioSourceChops.clip = player.song[0];
			audioSourceChops.time = player.chopTime[1];
			audioSourceChops.Play();
			audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[2]-player.chopTime[1]));
			render.color = selectedColor;					
		}	

		if (render.sprite.name == "sample 2" && player.chopTime.Count > 16) {
			audioSourceChops.clip = player.song[0];
			audioSourceChops.time = player.chopTime[2];
			audioSourceChops.Play();
			audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[3]-player.chopTime[2]));	
			render.color = selectedColor;				
		}		

		if (render.sprite.name == "sample 3" && player.chopTime.Count > 16) {
			audioSourceChops.clip = player.song[0];
			audioSourceChops.time = player.chopTime[3];
			audioSourceChops.Play();
			audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[4]-player.chopTime[3]));
			render.color = selectedColor;					
		}	

		if (render.sprite.name == "sample 4" && player.chopTime.Count > 16) {
			audioSourceChops.clip = player.song[0];
			audioSourceChops.time = player.chopTime[4];
			audioSourceChops.Play();
			audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[5]-player.chopTime[4]));
			render.color = selectedColor;					
		}

		if (render.sprite.name == "sample 5" && player.chopTime.Count > 16) {
			audioSourceChops.clip = player.song[0];
			audioSourceChops.time = player.chopTime[5];
			audioSourceChops.Play();
			audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[6]-player.chopTime[5]));
			render.color = selectedColor;					
		}

		if (render.sprite.name == "sample 6" && player.chopTime.Count > 16) {
			audioSourceChops.clip = player.song[0];
			audioSourceChops.time = player.chopTime[6];
			audioSourceChops.Play();
			audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[7]-player.chopTime[6]));
			render.color = selectedColor;					
		}	

		if (render.sprite.name == "sample 7" && player.chopTime.Count > 16) {
			audioSourceChops.clip = player.song[0];
			audioSourceChops.time = player.chopTime[7];
			audioSourceChops.Play();
			audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[8]-player.chopTime[7]));
			render.color = selectedColor;					
		}	

		if (render.sprite.name == "sample 8" && player.chopTime.Count > 16) {
			audioSourceChops.clip = player.song[0];
			audioSourceChops.time = player.chopTime[8];
			audioSourceChops.Play();
			audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[9]-player.chopTime[8]));
			render.color = selectedColor;					
		}	

		if (render.sprite.name == "sample 9" && player.chopTime.Count > 16) {
			audioSourceChops.clip = player.song[0];
			audioSourceChops.time = player.chopTime[9];
			audioSourceChops.Play();
			audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[10]-player.chopTime[9]));	
			render.color = selectedColor;				
		}	

		if (render.sprite.name == "sample 10" && player.chopTime.Count > 16) {
			audioSourceChops.clip = player.song[0];
			audioSourceChops.time = player.chopTime[10];
			audioSourceChops.Play();
			audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[11]-player.chopTime[10]));
			render.color = selectedColor;					
		}	

		if (render.sprite.name == "sample 11" && player.chopTime.Count > 16) {
			audioSourceChops.clip = player.song[0];
			audioSourceChops.time = player.chopTime[11];
			audioSourceChops.Play();
			audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[12]-player.chopTime[11]));
			render.color = selectedColor;					
		}	

		if (render.sprite.name == "sample 12" && player.chopTime.Count > 16) {
			audioSourceChops.clip = player.song[0];
			audioSourceChops.time = player.chopTime[12];
			audioSourceChops.Play();
			audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[13]-player.chopTime[12]));	
			render.color = selectedColor;				
		}	

		if (render.sprite.name == "sample 13" && player.chopTime.Count > 16) {
			audioSourceChops.clip = player.song[0];
			audioSourceChops.time = player.chopTime[13];
			audioSourceChops.Play();
			audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[14]-player.chopTime[13]));
			render.color = selectedColor;					
		}	

		if (render.sprite.name == "sample 14" && player.chopTime.Count > 16) {
			audioSourceChops.clip = player.song[0];
			audioSourceChops.time = player.chopTime[14];
			audioSourceChops.Play();
			audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[15]-player.chopTime[14]));
			render.color = selectedColor;					
		}	

		if (render.sprite.name == "sample 15" && player.chopTime.Count > 16) {
			audioSourceChops.clip = player.song[0];
			audioSourceChops.time = player.chopTime[15];
			audioSourceChops.Play();
			audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[16]-player.chopTime[15]));
			render.color = selectedColor;					
		}																										

		// Notes
		if (render.sprite.name == "note 0") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[0];						
			StartCoroutine(StopNote());						
		}

		if (render.sprite.name == "note 1") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[1];
			StartCoroutine(StopNote());
		}

		if (render.sprite.name == "note 2") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[2];
			StartCoroutine(StopNote());
		}

		if (render.sprite.name == "note 3") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[3];
			StartCoroutine(StopNote());
		}

		if (render.sprite.name == "note 4") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[4];
			StartCoroutine(StopNote());
		}

		if (render.sprite.name == "note 5") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[5];
			StartCoroutine(StopNote());
		}

		if (render.sprite.name == "note 6") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[6];
			StartCoroutine(StopNote());
		}	

		if (render.sprite.name == "note 7") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[7];
			StartCoroutine(StopNote());
		}

		if (render.sprite.name == "note 8") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[8];
			StartCoroutine(StopNote());
		}		

		if (render.sprite.name == "note 9") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[9];
			StartCoroutine(StopNote());
		}		

		if (render.sprite.name == "note 10") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[10];
			StartCoroutine(StopNote());
		}		

		if (render.sprite.name == "note 11") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[11];
			StartCoroutine(StopNote());
		}	

		if (render.sprite.name == "note 12") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[12];
			StartCoroutine(StopNote());
		}	

		if (render.sprite.name == "note 13") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[13];
			StartCoroutine(StopNote());
		}	

		if (render.sprite.name == "note 14") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[14];
			StartCoroutine(StopNote());
		}		

		if (render.sprite.name == "note 15") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[15];
			StartCoroutine(StopNote());
		}	

		//

		if (render.sprite.name == "note 16") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[16];
			StartCoroutine(StopNote());						
		}

		if (render.sprite.name == "note 17") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[17];
			StartCoroutine(StopNote());
		}

		if (render.sprite.name == "note 18") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[18];
			StartCoroutine(StopNote());
		}

		if (render.sprite.name == "note 19") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[19];
			StartCoroutine(StopNote());
		}

		if (render.sprite.name == "note 20") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[20];
			StartCoroutine(StopNote());
		}

		if (render.sprite.name == "note 21") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[21];
			StartCoroutine(StopNote());
		}

		if (render.sprite.name == "note 22") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[22];
			StartCoroutine(StopNote());
		}	

		if (render.sprite.name == "note 23") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[23];
			StartCoroutine(StopNote());
		}

		if (render.sprite.name == "note 24") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[24];
			StartCoroutine(StopNote());
		}		

		if (render.sprite.name == "note 25") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[25];
			StartCoroutine(StopNote());
		}		

		if (render.sprite.name == "note 26") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[26];
			StartCoroutine(StopNote());
		}		

		if (render.sprite.name == "note 27") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[27];
			StartCoroutine(StopNote());
		}	

		if (render.sprite.name == "note 28") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[28];
			StartCoroutine(StopNote());
		}	

		if (render.sprite.name == "note 29") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[29];
			StartCoroutine(StopNote());
		}	

		if (render.sprite.name == "note 30") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[30];
			StartCoroutine(StopNote());
		}		

		if (render.sprite.name == "note 31") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[31];
			StartCoroutine(StopNote());
		}	

		////

		if (render.sprite.name == "note 32") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[32];
			StartCoroutine(StopNote());						
		}

		if (render.sprite.name == "note 33") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[33];
			StartCoroutine(StopNote());
		}

		if (render.sprite.name == "note 34") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[34];
			StartCoroutine(StopNote());
		}

		if (render.sprite.name == "note 35") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[35];
			StartCoroutine(StopNote());
		}

		if (render.sprite.name == "note 36") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[36];
			StartCoroutine(StopNote());
		}

		if (render.sprite.name == "note 37") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[37];
			StartCoroutine(StopNote());
		}

		if (render.sprite.name == "note 38") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[38];
			StartCoroutine(StopNote());
		}	

		if (render.sprite.name == "note 39") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[39];
			StartCoroutine(StopNote());
		}

		if (render.sprite.name == "note 40") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[40];
			StartCoroutine(StopNote());
		}		

		if (render.sprite.name == "note 41") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[41];
			StartCoroutine(StopNote());
		}		

		if (render.sprite.name == "note 42") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[42];
			StartCoroutine(StopNote());
		}		

		if (render.sprite.name == "note 43") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[43];
			StartCoroutine(StopNote());
		}	

		if (render.sprite.name == "note 44") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[44];
			StartCoroutine(StopNote());
		}	

		if (render.sprite.name == "note 45") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[45];
			StartCoroutine(StopNote());
		}	

		if (render.sprite.name == "note 46") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[46];
			StartCoroutine(StopNote());
		}		

		if (render.sprite.name == "note 47") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[47];
			StartCoroutine(StopNote());
		}		

		////	

		if (render.sprite.name == "note 48") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[48];
			StartCoroutine(StopNote());						
		}

		if (render.sprite.name == "note 49") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[49];
			StartCoroutine(StopNote());
		}

		if (render.sprite.name == "note 50") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[50];
			StartCoroutine(StopNote());
		}

		if (render.sprite.name == "note 51") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[51];
			StartCoroutine(StopNote());
		}

		if (render.sprite.name == "note 52") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[52];
			StartCoroutine(StopNote());
		}

		if (render.sprite.name == "note 53") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[53];
			StartCoroutine(StopNote());
		}

		if (render.sprite.name == "note 54") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[54];
			StartCoroutine(StopNote());
		}	

		if (render.sprite.name == "note 55") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[55];
			StartCoroutine(StopNote());
		}

		if (render.sprite.name == "note 56") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[56];
			StartCoroutine(StopNote());
		}		

		if (render.sprite.name == "note 57") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[57];
			StartCoroutine(StopNote());
		}		

		if (render.sprite.name == "note 58") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[58];
			StartCoroutine(StopNote());
		}		

		if (render.sprite.name == "note 59") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[59];
			StartCoroutine(StopNote());
		}	

		if (render.sprite.name == "note 60") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[60];
			StartCoroutine(StopNote());
		}	

		if (render.sprite.name == "note 61") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[61];
			StartCoroutine(StopNote());
		}	

		if (render.sprite.name == "note 62") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[62];
			StartCoroutine(StopNote());
		}		

		if (render.sprite.name == "note 63") {
			render.color = selectedColor;	
			Oscillator1.GetComponent<Oscillator>().gain = synthVolume;
			Oscillator1.GetComponent<Oscillator>().frequency = Oscillator1.GetComponent<Oscillator>().frequencies[63];
			StartCoroutine(StopNote());
		}					

		mainCamera.GetComponent<CameraShake>().shakecamera();
		StartCoroutine(StopShakingCamera());
	}

	private void Deselect() {
		isSelected = false;
		render.color = Color.white;
		previousSelected = null;
	}

	void OnMouseDown() {
        RaycastHit hitInfo = new RaycastHit();
        if (Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hitInfo)) {
            //Debug.Log (hitInfo.collider.gameObject.name);
			clickedPad = GameObject.Find(hitInfo.collider.gameObject.name);
        }

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "blue 0") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.boards[0][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "green  0") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.boards[1][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "orange 0") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.boards[2][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "pink 0") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.boards[3][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "purple 0") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.boards[4][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "red 0") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.boards[5][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "turquoise  0") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.boards[6][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "yellow  0") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.boards[7][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		/////

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "sample 0") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.pad[0][jFound, kFound] = null;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "sample 1") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.pad[0][jFound, kFound] = null;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "sample 2") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.pad[0][jFound, kFound] = null;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "sample 3") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.pad[0][jFound, kFound] = null;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "sample 4") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.pad[0][jFound, kFound] = null;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "sample 5") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.pad[0][jFound, kFound] = null;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "sample 6") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.pad[0][jFound, kFound] = null;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "sample 7") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.pad[0][jFound, kFound] = null;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "sample 8") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.pad[0][jFound, kFound] = null;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "sample 9") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.pad[0][jFound, kFound] = null;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "sample 10") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.pad[0][jFound, kFound] = null;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "sample 11") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.pad[0][jFound, kFound] = null;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "sample 12") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.pad[0][jFound, kFound] = null;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "sample 13") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.pad[0][jFound, kFound] = null;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "sample 14") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.pad[0][jFound, kFound] = null;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "sample 15") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.pad[0][jFound, kFound] = null;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		////

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 0") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteLow[0][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 1") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteLow[1][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 2") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteLow[2][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 3") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteLow[3][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 4") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteLow[4][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 5") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteLow[5][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 6") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteLow[6][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 7") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteLow[7][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}		

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 8") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteLow[8][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}	

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 9") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteLow[9][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}	

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 10") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteLow[10][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}	

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 11") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteLow[11][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}		

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 12") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteLow[12][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}		

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 13") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteLow[13][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}	

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 14") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteLow[14][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}	

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 15") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteLow[15][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}	



		//



		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 16") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteMid[0][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 17") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteMid[1][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 18") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteMid[2][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 19") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteMid[3][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 20") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteMid[4][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 21") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteMid[5][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 22") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteMid[6][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 23") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteMid[7][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}		

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 24") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteMid[8][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}	

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 25") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteMid[9][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}	

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 26") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteMid[10][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}	

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 27") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteMid[11][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}		

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 28") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteMid[12][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}		

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 29") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteMid[13][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}	

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 30") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteMid[14][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}	

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 31") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteMid[15][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}




		/////



		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 32") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteHigh[0][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 33") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteHigh[1][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 34") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteHigh[2][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 35") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteHigh[3][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 36") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteHigh[4][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 37") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteHigh[5][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 38") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteHigh[6][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 39") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteHigh[7][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}		

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 40") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteHigh[8][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}	

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 41") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteHigh[9][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}	

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 42") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteHigh[10][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}	

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 43") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteHigh[11][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}		

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 44") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteHigh[12][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}		

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 45") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteHigh[13][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}	

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 46") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteHigh[14][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}	

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 47") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteHigh[15][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		/////


		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 48") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteSub[0][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 49") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteSub[1][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 50") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteSub[2][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 51") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteSub[3][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 52") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteSub[4][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 53") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteSub[5][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 54") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteSub[6][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 55") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteSub[7][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}		

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 56") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteSub[8][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}	

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 57") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteSub[9][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}	

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 58") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteSub[10][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}	

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 59") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteSub[11][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}		

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 60") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteSub[12][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}		

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 61") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteSub[13][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}	

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 62") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteSub[14][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}	

		if (render.tag == "blocks" && render.color == Color.white && render.sprite.name == "note 63") {
			if (FindIndicesOfObject(this.gameObject, out jFound, out kFound)) {
				OperatorManager.instance.noteSub[15][jFound, kFound] = false;
				render.sprite = block;
				GetComponent<RotateYaxis>().flipTile();
				StartCoroutine(resetflipTile());
				Instantiate(whiteParticles, transform.position, Quaternion.identity);
			}
		}				


		////


		if (render.sprite == null) {
		 	return;
		}

		if (isSelected) {
			Deselect();
		} else {
			if (previousSelected == null) {
				Select();
			} else {
				if (render.tag == "pads") {
					previousSelected.GetComponent<OperatorTile>().Deselect();
					Select();
				}

				if (render.tag == "blocks") {
					CopySprite(previousSelected.render);
					GetComponent<RotateYaxis>().flipTile();
					StartCoroutine(resetflipTile());
					Instantiate(whiteParticles, transform.position, Quaternion.identity);
				}
			}
		}
	}

	bool FindIndicesOfObject(GameObject objectToLookFor, out int j, out int k)
	{
		for (j = 0; j < OperatorManager.instance.boards.Length; j++)
		{
			for (k = 0; k < OperatorManager.instance.boards.Length; k++)
			{
				// Is this the one?
				if (OperatorManager.instance.tiles[j,k] == objectToLookFor)
				{
					return true;
				}
			}
		}
		j = k = -1;
		return false;
	}

	public void DisplayActiveBoard() {
		for (int y = 0; y < OperatorManager.instance.ySize; y++) {
			for (int x = 0; x < OperatorManager.instance.xSize; x++) {
				if (OperatorManager.instance.boards[0][x, y] == true && render.sprite.name == "blue 0") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = blue;
				}
				else if (OperatorManager.instance.boards[0][x, y] == false && render.sprite.name == "blue 0") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.boards[1][x, y] == true && render.sprite.name == "green  0") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = green;
				}
				else if (OperatorManager.instance.boards[1][x, y] == false && render.sprite.name == "green  0") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.boards[2][x, y] == true && render.sprite.name == "orange 0") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = orange;
				}
				else if (OperatorManager.instance.boards[2][x, y] == false && render.sprite.name == "orange 0") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.boards[3][x, y] == true && render.sprite.name == "pink 0") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = pink;
				}
				else if (OperatorManager.instance.boards[3][x, y] == false && render.sprite.name == "pink 0") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.boards[4][x, y] == true && render.sprite.name == "purple 0") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = purple;
				}
				else if (OperatorManager.instance.boards[4][x, y] == false && render.sprite.name == "purple 0") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.boards[5][x, y] == true && render.sprite.name == "red 0") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = red;
				}
				else if (OperatorManager.instance.boards[5][x, y] == false && render.sprite.name == "red 0") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.boards[6][x, y] == true && render.sprite.name == "turquoise  0") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = turquoise;
				}
				else if (OperatorManager.instance.boards[6][x, y] == false && render.sprite.name == "turquoise  0") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.boards[7][x, y] == true && render.sprite.name == "yellow  0") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = yellow;
				}
				else if (OperatorManager.instance.boards[7][x, y] == false && render.sprite.name == "yellow  0") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				////

				if (OperatorManager.instance.noteLow[0][x, y] == true && render.sprite.name == "note 0") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_0;
				}
				else if (OperatorManager.instance.noteLow[0][x, y] == false && render.sprite.name == "note 0") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}
				
				if (OperatorManager.instance.noteLow[1][x, y] == true && render.sprite.name == "note 1") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_1;
				}
				else if (OperatorManager.instance.noteLow[1][x, y] == false && render.sprite.name == "note 1") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteLow[2][x, y] == true && render.sprite.name == "note 2") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_2;
				}
				else if (OperatorManager.instance.noteLow[2][x, y] == false && render.sprite.name == "note 2") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteLow[3][x, y] == true && render.sprite.name == "note 3") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_3;
				}
				else if (OperatorManager.instance.noteLow[3][x, y] == false && render.sprite.name == "note 3") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteLow[4][x, y] == true && render.sprite.name == "note 4") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_4;
				}
				else if (OperatorManager.instance.noteLow[4][x, y] == false && render.sprite.name == "note 4") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}														

				if (OperatorManager.instance.noteLow[5][x, y] == true && render.sprite.name == "note 5") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_5;
				}
				else if (OperatorManager.instance.noteLow[5][x, y] == false && render.sprite.name == "note 5") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteLow[6][x, y] == true && render.sprite.name == "note 6") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_6;
				}
				else if (OperatorManager.instance.noteLow[6][x, y] == false && render.sprite.name == "note 6") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteLow[7][x, y] == true && render.sprite.name == "note 7") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_7;
				}
				else if (OperatorManager.instance.noteLow[7][x, y] == false && render.sprite.name == "note 7") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteLow[8][x, y] == true && render.sprite.name == "note 8") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_8;
				}
				else if (OperatorManager.instance.noteLow[8][x, y] == false && render.sprite.name == "note 8") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.noteLow[9][x, y] == true && render.sprite.name == "note 9") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_9;
				}
				else if (OperatorManager.instance.noteLow[9][x, y] == false && render.sprite.name == "note 9") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteLow[10][x, y] == true && render.sprite.name == "note 10") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_10;
				}
				else if (OperatorManager.instance.noteLow[10][x, y] == false && render.sprite.name == "note 10") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteLow[11][x, y] == true && render.sprite.name == "note 11") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_11;
				}
				else if (OperatorManager.instance.noteLow[11][x, y] == false && render.sprite.name == "note 11") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteLow[12][x, y] == true && render.sprite.name == "note 12") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_12;
				}
				else if (OperatorManager.instance.noteLow[12][x, y] == false && render.sprite.name == "note 12") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteLow[13][x, y] == true && render.sprite.name == "note 13") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_13;
				}
				else if (OperatorManager.instance.noteLow[13][x, y] == false && render.sprite.name == "note 13") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteLow[14][x, y] == true && render.sprite.name == "note 14") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_14;
				}
				else if (OperatorManager.instance.noteLow[14][x, y] == false && render.sprite.name == "note 14") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}			

				if (OperatorManager.instance.noteLow[15][x, y] == true && render.sprite.name == "note 15") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_15;
				}
				else if (OperatorManager.instance.noteLow[15][x, y] == false && render.sprite.name == "note 15") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}																																											



				////




				if (OperatorManager.instance.noteMid[0][x, y] == true && render.sprite.name == "note 16") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_16;
				}
				else if (OperatorManager.instance.noteMid[0][x, y] == false && render.sprite.name == "note 16") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}
				
				if (OperatorManager.instance.noteMid[1][x, y] == true && render.sprite.name == "note 17") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_17;
				}
				else if (OperatorManager.instance.noteMid[1][x, y] == false && render.sprite.name == "note 17") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteMid[2][x, y] == true && render.sprite.name == "note 18") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_18;
				}
				else if (OperatorManager.instance.noteMid[2][x, y] == false && render.sprite.name == "note 18") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteMid[3][x, y] == true && render.sprite.name == "note 19") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_19;
				}
				else if (OperatorManager.instance.noteMid[3][x, y] == false && render.sprite.name == "note 19") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteMid[4][x, y] == true && render.sprite.name == "note 20") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_20;
				}
				else if (OperatorManager.instance.noteMid[4][x, y] == false && render.sprite.name == "note 20") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}														

				if (OperatorManager.instance.noteMid[5][x, y] == true && render.sprite.name == "note 21") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_21;
				}
				else if (OperatorManager.instance.noteMid[5][x, y] == false && render.sprite.name == "note 21") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteMid[6][x, y] == true && render.sprite.name == "note 22") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_22;
				}
				else if (OperatorManager.instance.noteMid[6][x, y] == false && render.sprite.name == "note 22") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteMid[7][x, y] == true && render.sprite.name == "note 23") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_23;
				}
				else if (OperatorManager.instance.noteMid[7][x, y] == false && render.sprite.name == "note 23") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteMid[8][x, y] == true && render.sprite.name == "note 24") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_24;
				}
				else if (OperatorManager.instance.noteMid[8][x, y] == false && render.sprite.name == "note 24") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.noteMid[9][x, y] == true && render.sprite.name == "note 25") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_25;
				}
				else if (OperatorManager.instance.noteMid[9][x, y] == false && render.sprite.name == "note 25") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteMid[10][x, y] == true && render.sprite.name == "note 26") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_26;
				}
				else if (OperatorManager.instance.noteMid[10][x, y] == false && render.sprite.name == "note 26") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteMid[11][x, y] == true && render.sprite.name == "note 27") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_27;
				}
				else if (OperatorManager.instance.noteMid[11][x, y] == false && render.sprite.name == "note 27") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteMid[12][x, y] == true && render.sprite.name == "note 28") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_28;
				}
				else if (OperatorManager.instance.noteMid[12][x, y] == false && render.sprite.name == "note 28") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteMid[13][x, y] == true && render.sprite.name == "note 29") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_29;
				}
				else if (OperatorManager.instance.noteMid[13][x, y] == false && render.sprite.name == "note 29") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteMid[14][x, y] == true && render.sprite.name == "note 30") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_30;
				}
				else if (OperatorManager.instance.noteMid[14][x, y] == false && render.sprite.name == "note 30") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}			

				if (OperatorManager.instance.noteMid[15][x, y] == true && render.sprite.name == "note 31") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_31;
				}
				else if (OperatorManager.instance.noteMid[15][x, y] == false && render.sprite.name == "note 31") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}


				////


				if (OperatorManager.instance.noteHigh[0][x, y] == true && render.sprite.name == "note 32") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_32;
				}
				else if (OperatorManager.instance.noteHigh[0][x, y] == false && render.sprite.name == "note 32") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}
				
				if (OperatorManager.instance.noteHigh[1][x, y] == true && render.sprite.name == "note 33") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_33;
				}
				else if (OperatorManager.instance.noteHigh[1][x, y] == false && render.sprite.name == "note 33") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteHigh[2][x, y] == true && render.sprite.name == "note 34") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_34;
				}
				else if (OperatorManager.instance.noteHigh[2][x, y] == false && render.sprite.name == "note 34") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteHigh[3][x, y] == true && render.sprite.name == "note 35") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_35;
				}
				else if (OperatorManager.instance.noteHigh[3][x, y] == false && render.sprite.name == "note 35") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteHigh[4][x, y] == true && render.sprite.name == "note 36") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_36;
				}
				else if (OperatorManager.instance.noteHigh[4][x, y] == false && render.sprite.name == "note 36") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}														

				if (OperatorManager.instance.noteHigh[5][x, y] == true && render.sprite.name == "note 37") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_37;
				}
				else if (OperatorManager.instance.noteHigh[5][x, y] == false && render.sprite.name == "note 37") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteHigh[6][x, y] == true && render.sprite.name == "note 38") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_38;
				}
				else if (OperatorManager.instance.noteHigh[6][x, y] == false && render.sprite.name == "note 38") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteHigh[7][x, y] == true && render.sprite.name == "note 39") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_39;
				}
				else if (OperatorManager.instance.noteHigh[7][x, y] == false && render.sprite.name == "note 39") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteHigh[8][x, y] == true && render.sprite.name == "note 40") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_40;
				}
				else if (OperatorManager.instance.noteHigh[8][x, y] == false && render.sprite.name == "note 40") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.noteHigh[9][x, y] == true && render.sprite.name == "note 41") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_41;
				}
				else if (OperatorManager.instance.noteHigh[9][x, y] == false && render.sprite.name == "note 41") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteHigh[10][x, y] == true && render.sprite.name == "note 42") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_42;
				}
				else if (OperatorManager.instance.noteHigh[10][x, y] == false && render.sprite.name == "note 42") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteHigh[11][x, y] == true && render.sprite.name == "note 43") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_43;
				}
				else if (OperatorManager.instance.noteHigh[11][x, y] == false && render.sprite.name == "note 43") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteHigh[12][x, y] == true && render.sprite.name == "note 44") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_44;
				}
				else if (OperatorManager.instance.noteHigh[12][x, y] == false && render.sprite.name == "note 44") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteHigh[13][x, y] == true && render.sprite.name == "note 45") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_45;
				}
				else if (OperatorManager.instance.noteHigh[13][x, y] == false && render.sprite.name == "note 45") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteHigh[14][x, y] == true && render.sprite.name == "note 46") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_46;
				}
				else if (OperatorManager.instance.noteHigh[14][x, y] == false && render.sprite.name == "note 46") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}			

				if (OperatorManager.instance.noteHigh[15][x, y] == true && render.sprite.name == "note 47") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_47;
				}
				else if (OperatorManager.instance.noteHigh[15][x, y] == false && render.sprite.name == "note 47") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}


				////



				if (OperatorManager.instance.noteSub[0][x, y] == true && render.sprite.name == "note 48") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_48;
				}
				else if (OperatorManager.instance.noteSub[0][x, y] == false && render.sprite.name == "note 48") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}
				
				if (OperatorManager.instance.noteSub[1][x, y] == true && render.sprite.name == "note 49") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_49;
				}
				else if (OperatorManager.instance.noteSub[1][x, y] == false && render.sprite.name == "note 49") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteSub[2][x, y] == true && render.sprite.name == "note 50") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_50;
				}
				else if (OperatorManager.instance.noteSub[2][x, y] == false && render.sprite.name == "note 50") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteSub[3][x, y] == true && render.sprite.name == "note 51") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_51;
				}
				else if (OperatorManager.instance.noteSub[3][x, y] == false && render.sprite.name == "note 51") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteSub[4][x, y] == true && render.sprite.name == "note 52") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_52;
				}
				else if (OperatorManager.instance.noteSub[4][x, y] == false && render.sprite.name == "note 52") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}														

				if (OperatorManager.instance.noteSub[5][x, y] == true && render.sprite.name == "note 53") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_53;
				}
				else if (OperatorManager.instance.noteSub[5][x, y] == false && render.sprite.name == "note 53") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteSub[6][x, y] == true && render.sprite.name == "note 54") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_54;
				}
				else if (OperatorManager.instance.noteSub[6][x, y] == false && render.sprite.name == "note 54") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteSub[7][x, y] == true && render.sprite.name == "note 55") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_55;
				}
				else if (OperatorManager.instance.noteSub[7][x, y] == false && render.sprite.name == "note 55") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteSub[8][x, y] == true && render.sprite.name == "note 56") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_56;
				}
				else if (OperatorManager.instance.noteSub[8][x, y] == false && render.sprite.name == "note 56") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.noteSub[9][x, y] == true && render.sprite.name == "note 57") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_57;
				}
				else if (OperatorManager.instance.noteSub[9][x, y] == false && render.sprite.name == "note 57") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteSub[10][x, y] == true && render.sprite.name == "note 58") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_58;
				}
				else if (OperatorManager.instance.noteSub[10][x, y] == false && render.sprite.name == "note 58") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteSub[11][x, y] == true && render.sprite.name == "note 59") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_59;
				}
				else if (OperatorManager.instance.noteSub[11][x, y] == false && render.sprite.name == "note 59") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteSub[12][x, y] == true && render.sprite.name == "note 60") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_60;
				}
				else if (OperatorManager.instance.noteSub[12][x, y] == false && render.sprite.name == "note 60") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteSub[13][x, y] == true && render.sprite.name == "note 61") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_61;
				}
				else if (OperatorManager.instance.noteSub[13][x, y] == false && render.sprite.name == "note 61") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}	

				if (OperatorManager.instance.noteSub[14][x, y] == true && render.sprite.name == "note 62") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_62;
				}
				else if (OperatorManager.instance.noteSub[14][x, y] == false && render.sprite.name == "note 62") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}			

				if (OperatorManager.instance.noteSub[15][x, y] == true && render.sprite.name == "note 63") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = Note_63;
				}
				else if (OperatorManager.instance.noteSub[15][x, y] == false && render.sprite.name == "note 63") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}


				////


				if (OperatorManager.instance.chops[0][x, y] == true && render.sprite.name == "sample 0" && OperatorManager.instance.pad[0][x,y] == "sample 0") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = sample0;
				}
				else if (render.sprite.name == "sample 0") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.chops[0][x, y] == true && render.sprite.name == "sample 1" && OperatorManager.instance.pad[0][x,y] == "sample 1") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = sample1;
				}
				else if (render.sprite.name == "sample 1") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.chops[0][x, y] == true && render.sprite.name == "sample 2" && OperatorManager.instance.pad[0][x,y] == "sample 2") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = sample2;
				}
				else if (render.sprite.name == "sample 2") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.chops[0][x, y] == true && render.sprite.name == "sample 3" && OperatorManager.instance.pad[0][x,y] == "sample 3") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = sample3;
				}
				else if (render.sprite.name == "sample 3") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.chops[0][x, y] == true && render.sprite.name == "sample 4" && OperatorManager.instance.pad[0][x,y] == "sample 4") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = sample4;
				}
				else if (render.sprite.name == "sample 4") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.chops[0][x, y] == true && render.sprite.name == "sample 5" && OperatorManager.instance.pad[0][x,y] == "sample 5") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = sample5;
				}
				else if (render.sprite.name == "sample 5") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.chops[0][x, y] == true && render.sprite.name == "sample 6" && OperatorManager.instance.pad[0][x,y] == "sample 6") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = sample6;
				}
				else if (render.sprite.name == "sample 6") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.chops[0][x, y] == true && render.sprite.name == "sample 7" && OperatorManager.instance.pad[0][x,y] == "sample 7") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = sample7;
				}
				else if (render.sprite.name == "sample 7") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.chops[0][x, y] == true && render.sprite.name == "sample 8" && OperatorManager.instance.pad[0][x,y] == "sample 8") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = sample8;
				}
				else if (render.sprite.name == "sample 8") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.chops[0][x, y] == true && render.sprite.name == "sample 9" && OperatorManager.instance.pad[0][x,y] == "sample 9") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = sample9;
				}
				else if (render.sprite.name == "sample 9") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.chops[0][x, y] == true && render.sprite.name == "sample 10" && OperatorManager.instance.pad[0][x,y] == "sample 10") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = sample10;
				}
				else if (render.sprite.name == "sample 10") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.chops[0][x, y] == true && render.sprite.name == "sample 11" && OperatorManager.instance.pad[0][x,y] == "sample 11") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = sample11;
				}
				else if (render.sprite.name == "sample 11") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.chops[0][x, y] == true && render.sprite.name == "sample 12" && OperatorManager.instance.pad[0][x,y] == "sample 12") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = sample12;
				}
				else if (render.sprite.name == "sample 12") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.chops[0][x, y] == true && render.sprite.name == "sample 13" && OperatorManager.instance.pad[0][x,y] == "sample 13") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = sample13;
				}
				else if (render.sprite.name == "sample 13") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.chops[0][x, y] == true && render.sprite.name == "sample 14" && OperatorManager.instance.pad[0][x,y] == "sample 14") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = sample14;
				}
				else if (render.sprite.name == "sample 14") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}

				if (OperatorManager.instance.chops[0][x, y] == true && render.sprite.name == "sample 15" && OperatorManager.instance.pad[0][x,y] == "sample 15") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = sample15;
				}
				else if (render.sprite.name == "sample 15") {
					OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().sprite = block;
				}
			}
		}
	}

	public void CopySprite(SpriteRenderer render2) {
		if (render.sprite == render2.sprite) {
			return;
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "blue 0") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.boards[0][jFound,kFound] = true;
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}
		if (render.sprite.name == "block 0" && render2.sprite.name == "green  0") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.boards[1][jFound,kFound] = true;
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}
		if (render.sprite.name == "block 0" && render2.sprite.name == "orange 0") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.boards[2][jFound,kFound] = true;
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}
		if (render.sprite.name == "block 0" && render2.sprite.name == "pink 0") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.boards[3][jFound,kFound] = true;
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}
		if (render.sprite.name == "block 0" && render2.sprite.name == "purple 0") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.boards[4][jFound,kFound] = true;
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}
		if (render.sprite.name == "block 0" && render2.sprite.name == "red 0") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.boards[5][jFound,kFound] = true;
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}
		if (render.sprite.name == "block 0" && render2.sprite.name == "turquoise  0") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.boards[6][jFound,kFound] = true;
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}
		if (render.sprite.name == "block 0" && render2.sprite.name == "yellow  0") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.boards[7][jFound,kFound] = true;
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		//Copy chop
		if (render.sprite.name == "block 0" && render2.sprite.name == "sample 0") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.chops[0][jFound,kFound] = true;
				OperatorManager.instance.pad[0][jFound,kFound] = "sample 0";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "sample 1") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.chops[0][jFound,kFound] = true;
				OperatorManager.instance.pad[0][jFound,kFound] = "sample 1";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "sample 2") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.chops[0][jFound,kFound] = true;
				OperatorManager.instance.pad[0][jFound,kFound] = "sample 2";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "sample 3") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.chops[0][jFound,kFound] = true;
				OperatorManager.instance.pad[0][jFound,kFound] = "sample 3";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "sample 4") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.chops[0][jFound,kFound] = true;
				OperatorManager.instance.pad[0][jFound,kFound] = "sample 4";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "sample 5") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.chops[0][jFound,kFound] = true;
				OperatorManager.instance.pad[0][jFound,kFound] = "sample 5";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "sample 6") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.chops[0][jFound,kFound] = true;
				OperatorManager.instance.pad[0][jFound,kFound] = "sample 6";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "sample 7") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.chops[0][jFound,kFound] = true;
				OperatorManager.instance.pad[0][jFound,kFound] = "sample 7";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "sample 8") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.chops[0][jFound,kFound] = true;
				OperatorManager.instance.pad[0][jFound,kFound] = "sample 8";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "sample 9") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.chops[0][jFound,kFound] = true;
				OperatorManager.instance.pad[0][jFound,kFound] = "sample 9";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "sample 10") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.chops[0][jFound,kFound] = true;
				OperatorManager.instance.pad[0][jFound,kFound] = "sample 10";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "sample 11") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.chops[0][jFound,kFound] = true;
				OperatorManager.instance.pad[0][jFound,kFound] = "sample 11";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "sample 12") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.chops[0][jFound,kFound] = true;
				OperatorManager.instance.pad[0][jFound,kFound] = "sample 12";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "sample 13") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.chops[0][jFound,kFound] = true;
				OperatorManager.instance.pad[0][jFound,kFound] = "sample 13";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "sample 14") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.chops[0][jFound,kFound] = true;
				OperatorManager.instance.pad[0][jFound,kFound] = "sample 14";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "sample 15") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.chops[0][jFound,kFound] = true;
				OperatorManager.instance.pad[0][jFound,kFound] = "sample 15";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		// Copy Note
		if (render.sprite.name == "block 0" && render2.sprite.name == "note 0") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteLow[0][jFound,kFound] = true;
				OperatorManager.instance.notePadsLow[0][jFound,kFound] = "note 0";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 1") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteLow[1][jFound,kFound] = true;
				OperatorManager.instance.notePadsLow[0][jFound,kFound] = "note 1";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}		

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 2") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteLow[2][jFound,kFound] = true;
				OperatorManager.instance.notePadsLow[0][jFound,kFound] = "note 2";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 3") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteLow[3][jFound,kFound] = true;
				OperatorManager.instance.notePadsLow[0][jFound,kFound] = "note 3";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 4") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteLow[4][jFound,kFound] = true;
				OperatorManager.instance.notePadsLow[0][jFound,kFound] = "note 4";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 5") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteLow[5][jFound,kFound] = true;
				OperatorManager.instance.notePadsLow[0][jFound,kFound] = "note 5";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 6") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteLow[6][jFound,kFound] = true;
				OperatorManager.instance.notePadsLow[0][jFound,kFound] = "note 6";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 7") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteLow[7][jFound,kFound] = true;
				OperatorManager.instance.notePadsLow[0][jFound,kFound] = "note 7";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 8") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteLow[8][jFound,kFound] = true;
				OperatorManager.instance.notePadsLow[0][jFound,kFound] = "note 8";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 9") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteLow[9][jFound,kFound] = true;
				OperatorManager.instance.notePadsLow[0][jFound,kFound] = "note 9";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 10") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteLow[10][jFound,kFound] = true;
				OperatorManager.instance.notePadsLow[0][jFound,kFound] = "note 10";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 11") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteLow[11][jFound,kFound] = true;
				OperatorManager.instance.notePadsLow[0][jFound,kFound] = "note 11";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}					

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 12") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteLow[12][jFound,kFound] = true;
				OperatorManager.instance.notePadsLow[0][jFound,kFound] = "note 12";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 13") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteLow[13][jFound,kFound] = true;
				OperatorManager.instance.notePadsLow[0][jFound,kFound] = "note 13";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}		

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 14") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteLow[14][jFound,kFound] = true;
				OperatorManager.instance.notePadsLow[0][jFound,kFound] = "note 14";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 15") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteLow[15][jFound,kFound] = true;
				OperatorManager.instance.notePadsLow[0][jFound,kFound] = "note 15";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}		
	
	
	
		//////



		if (render.sprite.name == "block 0" && render2.sprite.name == "note 16") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteMid[0][jFound,kFound] = true;
				OperatorManager.instance.notePadsMid[0][jFound,kFound] = "note 16";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 17") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteMid[1][jFound,kFound] = true;
				OperatorManager.instance.notePadsMid[0][jFound,kFound] = "note 17";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}		

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 18") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteMid[2][jFound,kFound] = true;
				OperatorManager.instance.notePadsMid[0][jFound,kFound] = "note 18";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 19") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteMid[3][jFound,kFound] = true;
				OperatorManager.instance.notePadsMid[0][jFound,kFound] = "note 19";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 20") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteMid[4][jFound,kFound] = true;
				OperatorManager.instance.notePadsMid[0][jFound,kFound] = "note 20";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 21") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteMid[5][jFound,kFound] = true;
				OperatorManager.instance.notePadsMid[0][jFound,kFound] = "note 21";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 22") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteMid[6][jFound,kFound] = true;
				OperatorManager.instance.notePadsMid[0][jFound,kFound] = "note 22";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 23") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteMid[7][jFound,kFound] = true;
				OperatorManager.instance.notePadsMid[0][jFound,kFound] = "note 23";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 24") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteMid[8][jFound,kFound] = true;
				OperatorManager.instance.notePadsMid[0][jFound,kFound] = "note 24";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 25") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteMid[9][jFound,kFound] = true;
				OperatorManager.instance.notePadsMid[0][jFound,kFound] = "note 25";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 26") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteMid[10][jFound,kFound] = true;
				OperatorManager.instance.notePadsMid[0][jFound,kFound] = "note 26";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 27") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteMid[11][jFound,kFound] = true;
				OperatorManager.instance.notePadsMid[0][jFound,kFound] = "note 27";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}					

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 28") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteMid[12][jFound,kFound] = true;
				OperatorManager.instance.notePadsMid[0][jFound,kFound] = "note 28";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 29") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteMid[13][jFound,kFound] = true;
				OperatorManager.instance.notePadsMid[0][jFound,kFound] = "note 29";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}		

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 30") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteMid[14][jFound,kFound] = true;
				OperatorManager.instance.notePadsMid[0][jFound,kFound] = "note 30";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 31") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteMid[15][jFound,kFound] = true;
				OperatorManager.instance.notePadsMid[0][jFound,kFound] = "note 31";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	



		//////



		if (render.sprite.name == "block 0" && render2.sprite.name == "note 32") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteHigh[0][jFound,kFound] = true;
				OperatorManager.instance.notePadsHigh[0][jFound,kFound] = "note 32";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 33") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteHigh[1][jFound,kFound] = true;
				OperatorManager.instance.notePadsHigh[0][jFound,kFound] = "note 33";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}		

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 34") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteHigh[2][jFound,kFound] = true;
				OperatorManager.instance.notePadsHigh[0][jFound,kFound] = "note 34";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 35") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteHigh[3][jFound,kFound] = true;
				OperatorManager.instance.notePadsHigh[0][jFound,kFound] = "note 35";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 36") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteHigh[4][jFound,kFound] = true;
				OperatorManager.instance.notePadsHigh[0][jFound,kFound] = "note 36";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 37") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteHigh[5][jFound,kFound] = true;
				OperatorManager.instance.notePadsHigh[0][jFound,kFound] = "note 37";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 38") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteHigh[6][jFound,kFound] = true;
				OperatorManager.instance.notePadsHigh[0][jFound,kFound] = "note 38";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 39") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteHigh[7][jFound,kFound] = true;
				OperatorManager.instance.notePadsHigh[0][jFound,kFound] = "note 39";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 40") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteHigh[8][jFound,kFound] = true;
				OperatorManager.instance.notePadsHigh[0][jFound,kFound] = "note 40";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 41") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteHigh[9][jFound,kFound] = true;
				OperatorManager.instance.notePadsHigh[0][jFound,kFound] = "note 41";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 42") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteHigh[10][jFound,kFound] = true;
				OperatorManager.instance.notePadsHigh[0][jFound,kFound] = "note 42";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 43") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteHigh[11][jFound,kFound] = true;
				OperatorManager.instance.notePadsHigh[0][jFound,kFound] = "note 43";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}					

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 44") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteHigh[12][jFound,kFound] = true;
				OperatorManager.instance.notePadsHigh[0][jFound,kFound] = "note 44";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 45") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteHigh[13][jFound,kFound] = true;
				OperatorManager.instance.notePadsHigh[0][jFound,kFound] = "note 45";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}		

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 46") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteHigh[14][jFound,kFound] = true;
				OperatorManager.instance.notePadsHigh[0][jFound,kFound] = "note 46";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 47") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteHigh[15][jFound,kFound] = true;
				OperatorManager.instance.notePadsHigh[0][jFound,kFound] = "note 47";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}		


		//////



		if (render.sprite.name == "block 0" && render2.sprite.name == "note 48") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteSub[0][jFound,kFound] = true;
				OperatorManager.instance.notePadsSub[0][jFound,kFound] = "note 48";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 49") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteSub[1][jFound,kFound] = true;
				OperatorManager.instance.notePadsSub[0][jFound,kFound] = "note 49";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}		

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 50") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteSub[2][jFound,kFound] = true;
				OperatorManager.instance.notePadsSub[0][jFound,kFound] = "note 50";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 51") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteSub[3][jFound,kFound] = true;
				OperatorManager.instance.notePadsSub[0][jFound,kFound] = "note 51";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 52") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteSub[4][jFound,kFound] = true;
				OperatorManager.instance.notePadsSub[0][jFound,kFound] = "note 52";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 53") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteSub[5][jFound,kFound] = true;
				OperatorManager.instance.notePadsSub[0][jFound,kFound] = "note 53";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 54") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteSub[6][jFound,kFound] = true;
				OperatorManager.instance.notePadsSub[0][jFound,kFound] = "note 54";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 55") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteSub[7][jFound,kFound] = true;
				OperatorManager.instance.notePadsSub[0][jFound,kFound] = "note 55";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 56") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteSub[8][jFound,kFound] = true;
				OperatorManager.instance.notePadsSub[0][jFound,kFound] = "note 56";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 57") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteSub[9][jFound,kFound] = true;
				OperatorManager.instance.notePadsSub[0][jFound,kFound] = "note 57";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 58") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteSub[10][jFound,kFound] = true;
				OperatorManager.instance.notePadsSub[0][jFound,kFound] = "note 58";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 59") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteSub[11][jFound,kFound] = true;
				OperatorManager.instance.notePadsSub[0][jFound,kFound] = "note 59";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}					

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 60") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteSub[12][jFound,kFound] = true;
				OperatorManager.instance.notePadsSub[0][jFound,kFound] = "note 60";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 61") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteSub[13][jFound,kFound] = true;
				OperatorManager.instance.notePadsSub[0][jFound,kFound] = "note 61";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}		

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 62") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteSub[14][jFound,kFound] = true;
				OperatorManager.instance.notePadsSub[0][jFound,kFound] = "note 62";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	

		if (render.sprite.name == "block 0" && render2.sprite.name == "note 63") {
			if (FindIndicesOfObject(clickedPad, out jFound, out kFound)) {
				OperatorManager.instance.tiles[jFound,kFound].GetComponent<SpriteRenderer>().sprite = render2.sprite;
				OperatorManager.instance.noteSub[15][jFound,kFound] = true;
				OperatorManager.instance.notePadsSub[0][jFound,kFound] = "note 63";
				previousSelected.GetComponent<OperatorTile>().Deselect();
				Select();
			}
		}	
	}




	public IEnumerator TriggerWave() {
		while (true) {
			if (!hasCoroutineStarted) {
				for (int y = 0; y < OperatorManager.instance.ySize; y++) {
					for (int x = 0; x < OperatorManager.instance.xSize; x++) {
						blockTiles[x,y].color = selectedColor;

						stepCount = y * 8 + x;

						// Play drum samples
						if (padTiles[0,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.boards[0][x, y] == true) {
							sampleClip = samples[0];
							audioSource0.clip = sampleClip;
							audioSource0.Play();
							padTiles[0,0].color = selectedColor;
						}
						else if (padTiles[0,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.boards[0][x, y] == false) {
							padTiles[0,0].color = Color.white;
						}

						if (padTiles[1,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.boards[1][x, y] == true) {
							sampleClip = samples[1];
							audioSource1.clip = sampleClip;
							audioSource1.Play();
							padTiles[1,0].color = selectedColor;
						}
						else if (padTiles[1,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.boards[0][x, y] == false) {
							padTiles[1,0].color = Color.white;
						}

						if (padTiles[2,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.boards[2][x, y] == true) {
							sampleClip = samples[2];
							audioSource2.clip = sampleClip;
							audioSource2.Play();
							padTiles[2,0].color = selectedColor;
						}
						else if (padTiles[2,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.boards[0][x, y] == false) {
							padTiles[2,0].color = Color.white;
						}

						if (padTiles[3,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.boards[3][x, y] == true) {
							sampleClip = samples[3];
							audioSource3.clip = sampleClip;
							audioSource3.Play();
							padTiles[3,0].color = selectedColor;
						}
						else if (padTiles[3,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.boards[0][x, y] == false) {
							padTiles[3,0].color = Color.white;
						}

						if (padTiles[4,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.boards[4][x, y] == true) {
							sampleClip = samples[4];
							audioSource4.clip = sampleClip;
							audioSource4.Play();
							padTiles[4,0].color = selectedColor;
						}
						else if (padTiles[4,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.boards[0][x, y] == false) {
							padTiles[4,0].color = Color.white;
						}

						if (padTiles[5,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.boards[5][x, y] == true) {
							sampleClip = samples[5];
							audioSource5.clip = sampleClip;
							audioSource5.Play();
							padTiles[5,0].color = selectedColor;
						}
						else if (padTiles[5,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.boards[0][x, y] == false) {
							padTiles[5,0].color = Color.white;
						}

						if (padTiles[6,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.boards[6][x, y] == true) {
							sampleClip = samples[6];
							audioSource6.clip = sampleClip;
							audioSource6.Play();
							padTiles[6,0].color = selectedColor;
						}
						else if (padTiles[6,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.boards[0][x, y] == false) {
							padTiles[6,0].color = Color.white;
						}

						if (padTiles[7,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.boards[7][x, y] == true) {
							sampleClip = samples[7];
							audioSource7.clip = sampleClip;
							audioSource7.Play();
							padTiles[7,0].color = selectedColor;
						}
						else if (padTiles[7,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.boards[0][x, y] == false) {
							padTiles[7,0].color = Color.white;
						}

						//Play chops
						if (OperatorManager.instance.pad[0][jFound,kFound] == "sample 0" && OperatorManager.instance.chops[0][x, y] == true && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							audioSourceChops.clip = player.song[player.currentIndex];
							audioSourceChops.time = player.chopTime[0];
							audioSourceChops.Play();
							audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[1]-player.chopTime[0]));
							padTiles[0,1].color = selectedColor;
						}
						else if (OperatorManager.instance.chops[0][x, y] == false && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							padTiles[0,1].color = Color.white;
						}

						if (OperatorManager.instance.pad[0][jFound,kFound] == "sample 1" && OperatorManager.instance.chops[0][x, y] == true && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							audioSourceChops.clip = player.song[player.currentIndex];
							audioSourceChops.time = player.chopTime[1];
							audioSourceChops.Play();
							audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[2]-player.chopTime[1]));	
							padTiles[1,1].color = selectedColor;
						}
						else if (OperatorManager.instance.chops[0][x, y] == false && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							padTiles[1,1].color = Color.white;
						}

						if (OperatorManager.instance.pad[0][jFound,kFound] == "sample 2" && OperatorManager.instance.chops[0][x, y] == true && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							audioSourceChops.clip = player.song[player.currentIndex];
							audioSourceChops.time = player.chopTime[2];
							audioSourceChops.Play();
							audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[3]-player.chopTime[2]));
							padTiles[2,1].color = selectedColor;
						}
						else if (OperatorManager.instance.chops[0][x, y] == false && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							padTiles[2,1].color = Color.white;
						}

						if (OperatorManager.instance.pad[0][jFound,kFound] == "sample 3" && OperatorManager.instance.chops[0][x, y] == true && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							audioSourceChops.clip = player.song[player.currentIndex];
							audioSourceChops.time = player.chopTime[3];
							audioSourceChops.Play();
							audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[4]-player.chopTime[3]));
							padTiles[3,1].color = selectedColor;
						}
						else if (OperatorManager.instance.chops[0][x, y] == false && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							padTiles[3,1].color = Color.white;
						}

						if (OperatorManager.instance.pad[0][jFound,kFound] == "sample 4" && OperatorManager.instance.chops[0][x, y] == true && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							audioSourceChops.clip = player.song[player.currentIndex];
							audioSourceChops.time = player.chopTime[4];
							audioSourceChops.Play();
							audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[5]-player.chopTime[4]));
							padTiles[4,1].color = selectedColor;
						}
						else if (OperatorManager.instance.chops[0][x, y] == false && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							padTiles[4,1].color = Color.white;
						}

						if (OperatorManager.instance.pad[0][jFound,kFound] == "sample 5" && OperatorManager.instance.chops[0][x, y] == true && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							audioSourceChops.clip = player.song[player.currentIndex];
							audioSourceChops.time = player.chopTime[5];
							audioSourceChops.Play();
							audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[6]-player.chopTime[5]));
							padTiles[5,1].color = selectedColor;
						}
						else if (OperatorManager.instance.chops[0][x, y] == false && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							padTiles[5,1].color = Color.white;
						}

						if (OperatorManager.instance.pad[0][jFound,kFound] == "sample 6" && OperatorManager.instance.chops[0][x, y] == true && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							audioSourceChops.clip = player.song[player.currentIndex];
							audioSourceChops.time = player.chopTime[6];
							audioSourceChops.Play();
							audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[7]-player.chopTime[6]));
							padTiles[6,1].color = selectedColor;
						}
						else if (OperatorManager.instance.chops[0][x, y] == false && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							padTiles[6,1].color = Color.white;
						}

						if (OperatorManager.instance.pad[0][jFound,kFound] == "sample 7" && OperatorManager.instance.chops[0][x, y] == true && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							audioSourceChops.clip = player.song[player.currentIndex];
							audioSourceChops.time = player.chopTime[7];
							audioSourceChops.Play();
							audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[8]-player.chopTime[7]));
							padTiles[7,1].color = selectedColor;
						}
						else if (OperatorManager.instance.chops[0][x, y] == false && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							padTiles[7,1].color = Color.white;
						}

						if (OperatorManager.instance.pad[0][jFound,kFound] == "sample 8" && OperatorManager.instance.chops[0][x, y] == true && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							audioSourceChops.clip = player.song[player.currentIndex];
							audioSourceChops.time = player.chopTime[8];
							audioSourceChops.Play();
							audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[9]-player.chopTime[8]));
							padTiles[0,2].color = selectedColor;
						}
						else if (OperatorManager.instance.chops[0][x, y] == false && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							padTiles[0,2].color = Color.white;
						}

						if (OperatorManager.instance.pad[0][jFound,kFound] == "sample 9" && OperatorManager.instance.chops[0][x, y] == true && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							audioSourceChops.clip = player.song[player.currentIndex];
							audioSourceChops.time = player.chopTime[9];
							audioSourceChops.Play();
							audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[10]-player.chopTime[9]));
							padTiles[1,2].color = selectedColor;
						}
						else if (OperatorManager.instance.chops[0][x, y] == false && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							padTiles[1,2].color = Color.white;
						}

						if (OperatorManager.instance.pad[0][jFound,kFound] == "sample 10" && OperatorManager.instance.chops[0][x, y] == true && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							audioSourceChops.clip = player.song[player.currentIndex];
							audioSourceChops.time = player.chopTime[10];
							audioSourceChops.Play();
							audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[11]-player.chopTime[10]));
							padTiles[2,2].color = selectedColor;
						}
						else if (OperatorManager.instance.chops[0][x, y] == false && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							padTiles[2,2].color = Color.white;
						}

						if (OperatorManager.instance.pad[0][jFound,kFound] == "sample 11" && OperatorManager.instance.chops[0][x, y] == true && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							audioSourceChops.clip = player.song[player.currentIndex];
							audioSourceChops.time = player.chopTime[11];
							audioSourceChops.Play();
							audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[12]-player.chopTime[11]));
							padTiles[3,2].color = selectedColor;
						}
						else if (OperatorManager.instance.chops[0][x, y] == false && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							padTiles[3,2].color = Color.white;
						}

						if (OperatorManager.instance.pad[0][jFound,kFound] == "sample 12" && OperatorManager.instance.chops[0][x, y] == true && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							audioSourceChops.clip = player.song[player.currentIndex];
							audioSourceChops.time = player.chopTime[12];
							audioSourceChops.Play();
							audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[13]-player.chopTime[12]));
							padTiles[4,2].color = selectedColor;
						}
						else if (OperatorManager.instance.chops[0][x, y] == false && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							padTiles[4,2].color = Color.white;
						}

						if (OperatorManager.instance.pad[0][jFound,kFound] == "sample 13" && OperatorManager.instance.chops[0][x, y] == true && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							audioSourceChops.clip = player.song[player.currentIndex];
							audioSourceChops.time = player.chopTime[13];
							audioSourceChops.Play();
							audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[14]-player.chopTime[13]));
							padTiles[5,2].color = selectedColor;
						}
						else if (OperatorManager.instance.chops[0][x, y] == false && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							padTiles[5,2].color = Color.white;
						}

						if (OperatorManager.instance.pad[0][jFound,kFound] == "sample 14" && OperatorManager.instance.chops[0][x, y] == true && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							audioSourceChops.clip = player.song[player.currentIndex];
							audioSourceChops.time = player.chopTime[14];
							audioSourceChops.Play();
							audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[15]-player.chopTime[14]));
							padTiles[6,2].color = selectedColor;
						}
						else if (OperatorManager.instance.chops[0][x, y] == false && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							padTiles[6,2].color = Color.white;
						}

						if (OperatorManager.instance.pad[0][jFound,kFound] == "sample 15" && OperatorManager.instance.chops[0][x, y] == true && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							audioSourceChops.clip = player.song[player.currentIndex];
							audioSourceChops.time = player.chopTime[15];
							audioSourceChops.Play();
							audioSourceChops.SetScheduledEndTime(AudioSettings.dspTime+(player.chopTime[16]-player.chopTime[15]));
							padTiles[7,2].color = selectedColor;
						}
						else if (OperatorManager.instance.chops[0][x, y] == false && gameObject.name == OperatorManager.instance.tiles[x, y].name) {
							padTiles[7,2].color = Color.white;
						}										




						// Play synth
						if (noteTilesLow[0,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[0][x, y] == true) {
							SynthSource_0.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_0.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_0.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_0.GetComponent<Oscillator>().frequency = SynthSource_0.GetComponent<Oscillator>().frequencies[0];
							SynthSource_0.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_0.GetComponent<AudioEchoFilter>().wetMix = wetMix;
							noteTilesLow[0,0].color = selectedColor;
						}
						else if (noteTilesLow[0,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[0][x, y] == false) {
							noteTilesLow[0,0].color = Color.white;
							SynthSource_0.GetComponent<Oscillator>().gain = 0;
						}												

						if (noteTilesLow[1,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[1][x, y] == true) {
                            SynthSource_1.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_1.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_1.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_1.GetComponent<Oscillator>().frequency = SynthSource_1.GetComponent<Oscillator>().frequencies[1];
							SynthSource_1.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_1.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesLow[1,0].color = selectedColor;
						}
						else if (noteTilesLow[1,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[1][x, y] == false) {
							noteTilesLow[1,0].color = Color.white;
							SynthSource_1.GetComponent<Oscillator>().gain = 0;
						}			

						if (noteTilesLow[2,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[2][x, y] == true) {
							SynthSource_2.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_2.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_2.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_2.GetComponent<Oscillator>().frequency = SynthSource_2.GetComponent<Oscillator>().frequencies[2];
							SynthSource_2.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_2.GetComponent<AudioEchoFilter>().wetMix = wetMix;
							noteTilesLow[2,0].color = selectedColor;
						}
						else if (noteTilesLow[2,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[2][x, y] == false) {
							noteTilesLow[2,0].color = Color.white;
							SynthSource_2.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesLow[3,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[3][x, y] == true) {
							SynthSource_3.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_3.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_3.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_3.GetComponent<Oscillator>().frequency = SynthSource_3.GetComponent<Oscillator>().frequencies[3];	
							SynthSource_3.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_3.GetComponent<AudioEchoFilter>().wetMix = wetMix;
							noteTilesLow[3,0].color = selectedColor;
						}
						else if (noteTilesLow[3,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[3][x, y] == false) {
							noteTilesLow[3,0].color = Color.white;
							SynthSource_3.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesLow[4,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[4][x, y] == true) {
							SynthSource_4.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_4.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_4.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_4.GetComponent<Oscillator>().frequency = SynthSource_4.GetComponent<Oscillator>().frequencies[4];
							SynthSource_4.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_4.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesLow[4,0].color = selectedColor;
						}
						else if (noteTilesLow[4,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[4][x, y] == false) {
							noteTilesLow[4,0].color = Color.white;
							SynthSource_4.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesLow[5,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[5][x, y] == true) {
							SynthSource_5.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_5.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_5.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_5.GetComponent<Oscillator>().frequency = SynthSource_5.GetComponent<Oscillator>().frequencies[5];
							SynthSource_5.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_5.GetComponent<AudioEchoFilter>().wetMix = wetMix;
							noteTilesLow[5,0].color = selectedColor;
						}
						else if (noteTilesLow[5,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[5][x, y] == false) {
							noteTilesLow[5,0].color = Color.white;
							SynthSource_5.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesLow[6,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[6][x, y] == true) {
							SynthSource_6.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_6.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_6.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_6.GetComponent<Oscillator>().frequency = SynthSource_6.GetComponent<Oscillator>().frequencies[6];
							SynthSource_6.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_6.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesLow[6,0].color = selectedColor;
						}
						else if (noteTilesLow[6,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[6][x, y] == false) {
							noteTilesLow[6,0].color = Color.white;
							SynthSource_6.GetComponent<Oscillator>().gain = 0;
						}

						if (noteTilesLow[7,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[7][x, y] == true) {
							SynthSource_7.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_7.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_7.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_7.GetComponent<Oscillator>().frequency = SynthSource_7.GetComponent<Oscillator>().frequencies[7];	
							SynthSource_7.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_7.GetComponent<AudioEchoFilter>().wetMix = wetMix;
							noteTilesLow[7,0].color = selectedColor;
						}
						else if (noteTilesLow[7,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[7][x, y] == false) {
							noteTilesLow[7,0].color = Color.white;
							SynthSource_7.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesLow[0,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[8][x, y] == true) {
							SynthSource_8.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_8.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_8.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_8.GetComponent<Oscillator>().frequency = SynthSource_8.GetComponent<Oscillator>().frequencies[8];
							SynthSource_8.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_8.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesLow[0,1].color = selectedColor;
						}
						else if (noteTilesLow[0,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[8][x, y] == false) {
							noteTilesLow[0,1].color = Color.white;
							SynthSource_8.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesLow[1,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[9][x, y] == true) {
							SynthSource_9.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_9.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_9.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_9.GetComponent<Oscillator>().frequency = SynthSource_9.GetComponent<Oscillator>().frequencies[9];
							SynthSource_9.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_9.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesLow[1,1].color = selectedColor;
						}
						else if (noteTilesLow[1,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[9][x, y] == false) {
							noteTilesLow[1,1].color = Color.white;
							SynthSource_9.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesLow[2,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[10][x, y] == true) {
							SynthSource_10.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_10.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_10.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_10.GetComponent<Oscillator>().frequency = SynthSource_10.GetComponent<Oscillator>().frequencies[10];
							SynthSource_10.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_10.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesLow[2,1].color = selectedColor;
						}
						else if (noteTilesLow[2,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[10][x, y] == false) {
							noteTilesLow[2,1].color = Color.white;
							SynthSource_10.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesLow[3,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[11][x, y] == true) {
							SynthSource_11.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_11.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_11.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_11.GetComponent<Oscillator>().frequency = SynthSource_11.GetComponent<Oscillator>().frequencies[11];	
							SynthSource_11.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_11.GetComponent<AudioEchoFilter>().wetMix = wetMix;
							noteTilesLow[3,1].color = selectedColor;
						}
						else if (noteTilesLow[3,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[11][x, y] == false) {
							noteTilesLow[3,1].color = Color.white;
							SynthSource_11.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesLow[4,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[12][x, y] == true) {
							SynthSource_12.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_12.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_12.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_12.GetComponent<Oscillator>().frequency = SynthSource_12.GetComponent<Oscillator>().frequencies[12];
							SynthSource_12.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_12.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesLow[4,1].color = selectedColor;
						}
						else if (noteTilesLow[4,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[12][x, y] == false) {
							noteTilesLow[4,1].color = Color.white;
							SynthSource_12.GetComponent<Oscillator>().gain = 0;
						}		

						if (noteTilesLow[5,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[13][x, y] == true) {
							SynthSource_13.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_13.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_13.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_13.GetComponent<Oscillator>().frequency = SynthSource_13.GetComponent<Oscillator>().frequencies[13];
							SynthSource_13.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_13.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesLow[5,1].color = selectedColor;
						}
						else if (noteTilesLow[5,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[13][x, y] == false) {
							noteTilesLow[5,1].color = Color.white;
							SynthSource_13.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesLow[6,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[14][x, y] == true) {
							SynthSource_14.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_14.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_14.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_14.GetComponent<Oscillator>().frequency = SynthSource_14.GetComponent<Oscillator>().frequencies[14];
							SynthSource_14.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_14.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesLow[6,1].color = selectedColor;
						}
						else if (noteTilesLow[6,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[14][x, y] == false) {
							noteTilesLow[6,1].color = Color.white;
							SynthSource_14.GetComponent<Oscillator>().gain = 0;
						}			

						if (noteTilesLow[7,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[15][x, y] == true) {
							SynthSource_15.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_15.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_15.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_15.GetComponent<Oscillator>().frequency = SynthSource_15.GetComponent<Oscillator>().frequencies[15];	
							SynthSource_15.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_15.GetComponent<AudioEchoFilter>().wetMix = wetMix;
							noteTilesLow[7,1].color = selectedColor;
						}
						else if (noteTilesLow[7,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteLow[15][x, y] == false) {
							noteTilesLow[7,1].color = Color.white;
							SynthSource_15.GetComponent<Oscillator>().gain = 0;
						}	


						/////



						if (noteTilesMid[0,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[0][x, y] == true) {
							SynthSource_16.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_16.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_16.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_16.GetComponent<Oscillator>().frequency = SynthSource_16.GetComponent<Oscillator>().frequencies[16];
							SynthSource_16.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_16.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesMid[0,0].color = selectedColor;
						}
						else if (noteTilesMid[0,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[0][x, y] == false) {
							noteTilesMid[0,0].color = Color.white;
							SynthSource_16.GetComponent<Oscillator>().gain = 0;
						}

						if (noteTilesMid[1,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[1][x, y] == true) {
                            SynthSource_17.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_17.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_17.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_17.GetComponent<Oscillator>().frequency = SynthSource_17.GetComponent<Oscillator>().frequencies[17];
							SynthSource_17.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_17.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesMid[1,0].color = selectedColor;
						}
						else if (noteTilesMid[1,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[1][x, y] == false) {
							noteTilesMid[1,0].color = Color.white;
							SynthSource_17.GetComponent<Oscillator>().gain = 0;
						}			

						if (noteTilesMid[2,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[2][x, y] == true) {
							SynthSource_18.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_18.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_18.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_18.GetComponent<Oscillator>().frequency = SynthSource_18.GetComponent<Oscillator>().frequencies[18];
							SynthSource_18.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_18.GetComponent<AudioEchoFilter>().wetMix = wetMix;
							noteTilesMid[2,0].color = selectedColor;
						}
						else if (noteTilesMid[2,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[2][x, y] == false) {
							noteTilesMid[2,0].color = Color.white;
							SynthSource_18.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesMid[3,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[3][x, y] == true) {
							SynthSource_19.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_19.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_19.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_19.GetComponent<Oscillator>().frequency = SynthSource_19.GetComponent<Oscillator>().frequencies[19];
							SynthSource_19.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_19.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesMid[3,0].color = selectedColor;
						}
						else if (noteTilesMid[3,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[3][x, y] == false) {
							noteTilesMid[3,0].color = Color.white;
							SynthSource_19.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesMid[4,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[4][x, y] == true) {
							SynthSource_20.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_20.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_20.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_20.GetComponent<Oscillator>().frequency = SynthSource_20.GetComponent<Oscillator>().frequencies[20];
							SynthSource_20.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_20.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesMid[4,0].color = selectedColor;
						}
						else if (noteTilesMid[4,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[4][x, y] == false) {
							noteTilesMid[4,0].color = Color.white;
							SynthSource_20.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesMid[5,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[5][x, y] == true) {
							SynthSource_21.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_21.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_21.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_21.GetComponent<Oscillator>().frequency = SynthSource_21.GetComponent<Oscillator>().frequencies[21];
							SynthSource_21.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_21.GetComponent<AudioEchoFilter>().wetMix = wetMix;
							noteTilesMid[5,0].color = selectedColor;
						}
						else if (noteTilesMid[5,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[5][x, y] == false) {
							noteTilesMid[5,0].color = Color.white;
							SynthSource_21.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesMid[6,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[6][x, y] == true) {
							SynthSource_22.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_22.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_22.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_22.GetComponent<Oscillator>().frequency = SynthSource_22.GetComponent<Oscillator>().frequencies[22];
							SynthSource_22.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_22.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesMid[6,0].color = selectedColor;
						}
						else if (noteTilesMid[6,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[6][x, y] == false) {
							noteTilesMid[6,0].color = Color.white;
							SynthSource_22.GetComponent<Oscillator>().gain = 0;
						}

						if (noteTilesMid[7,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[7][x, y] == true) {
							SynthSource_23.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_23.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_23.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_23.GetComponent<Oscillator>().frequency = SynthSource_23.GetComponent<Oscillator>().frequencies[23];
							SynthSource_23.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_23.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesMid[7,0].color = selectedColor;
						}
						else if (noteTilesMid[7,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[7][x, y] == false) {
							noteTilesMid[7,0].color = Color.white;
							SynthSource_23.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesMid[0,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[8][x, y] == true) {
							SynthSource_24.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_24.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_24.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_24.GetComponent<Oscillator>().frequency = SynthSource_24.GetComponent<Oscillator>().frequencies[24];
							SynthSource_24.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_24.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesMid[0,1].color = selectedColor;
						}
						else if (noteTilesMid[0,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[8][x, y] == false) {
							noteTilesMid[0,1].color = Color.white;
							SynthSource_24.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesMid[1,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[9][x, y] == true) {
							SynthSource_25.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_25.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_25.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_25.GetComponent<Oscillator>().frequency = SynthSource_25.GetComponent<Oscillator>().frequencies[25];
							SynthSource_25.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_25.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesMid[1,1].color = selectedColor;
						}
						else if (noteTilesMid[1,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[9][x, y] == false) {
							noteTilesMid[1,1].color = Color.white;
							SynthSource_25.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesMid[2,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[10][x, y] == true) {
							SynthSource_26.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_26.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_26.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_26.GetComponent<Oscillator>().frequency = SynthSource_26.GetComponent<Oscillator>().frequencies[26];
							SynthSource_26.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_26.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesMid[2,1].color = selectedColor;
						}
						else if (noteTilesMid[2,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[10][x, y] == false) {
							noteTilesMid[2,1].color = Color.white;
							SynthSource_26.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesMid[3,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[11][x, y] == true) {
							SynthSource_27.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_27.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_27.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_27.GetComponent<Oscillator>().frequency = SynthSource_27.GetComponent<Oscillator>().frequencies[27];
							SynthSource_27.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_27.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesMid[3,1].color = selectedColor;
						}
						else if (noteTilesMid[3,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[11][x, y] == false) {
							noteTilesMid[3,1].color = Color.white;
							SynthSource_27.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesMid[4,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[12][x, y] == true) {
							SynthSource_28.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_28.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_28.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_28.GetComponent<Oscillator>().frequency = SynthSource_28.GetComponent<Oscillator>().frequencies[28];
							SynthSource_28.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_28.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesMid[4,1].color = selectedColor;
						}
						else if (noteTilesMid[4,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[12][x, y] == false) {
							noteTilesMid[4,1].color = Color.white;
							SynthSource_28.GetComponent<Oscillator>().gain = 0;
						}		

						if (noteTilesMid[5,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[13][x, y] == true) {
							SynthSource_29.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_29.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_29.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_29.GetComponent<Oscillator>().frequency = SynthSource_29.GetComponent<Oscillator>().frequencies[29];	
							SynthSource_29.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_29.GetComponent<AudioEchoFilter>().wetMix = wetMix;
							noteTilesMid[5,1].color = selectedColor;
						}
						else if (noteTilesMid[5,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[13][x, y] == false) {
							noteTilesMid[5,1].color = Color.white;
							SynthSource_29.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesMid[6,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[14][x, y] == true) {
							SynthSource_30.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_30.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_30.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_30.GetComponent<Oscillator>().frequency = SynthSource_30.GetComponent<Oscillator>().frequencies[30];
							SynthSource_30.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_30.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesMid[6,1].color = selectedColor;
						}
						else if (noteTilesMid[6,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[14][x, y] == false) {
							noteTilesMid[6,1].color = Color.white;
							SynthSource_30.GetComponent<Oscillator>().gain = 0;
						}			

						if (noteTilesMid[7,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[15][x, y] == true) {
							SynthSource_31.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_31.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_31.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_31.GetComponent<Oscillator>().frequency = SynthSource_31.GetComponent<Oscillator>().frequencies[31];
							SynthSource_31.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_31.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesMid[7,1].color = selectedColor;
						}
						else if (noteTilesMid[7,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteMid[15][x, y] == false) {
							noteTilesMid[7,1].color = Color.white;
							SynthSource_31.GetComponent<Oscillator>().gain = 0;
						}


						/////	



						if (noteTilesHigh[0,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[0][x, y] == true) {
							SynthSource_32.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_32.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_32.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_32.GetComponent<Oscillator>().frequency = SynthSource_32.GetComponent<Oscillator>().frequencies[32];
							SynthSource_32.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_32.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesHigh[0,0].color = selectedColor;
						}
						else if (noteTilesHigh[0,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[0][x, y] == false) {
							noteTilesHigh[0,0].color = Color.white;
							SynthSource_32.GetComponent<Oscillator>().gain = 0;
						}

						if (noteTilesHigh[1,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[1][x, y] == true) {
                            SynthSource_33.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_33.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_33.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_33.GetComponent<Oscillator>().frequency = SynthSource_33.GetComponent<Oscillator>().frequencies[33];
							SynthSource_33.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_33.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesHigh[1,0].color = selectedColor;
						}
						else if (noteTilesHigh[1,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[1][x, y] == false) {
							noteTilesHigh[1,0].color = Color.white;
							SynthSource_33.GetComponent<Oscillator>().gain = 0;
						}			

						if (noteTilesHigh[2,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[2][x, y] == true) {
							SynthSource_34.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_34.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_34.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_34.GetComponent<Oscillator>().frequency = SynthSource_34.GetComponent<Oscillator>().frequencies[34];
							SynthSource_34.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_34.GetComponent<AudioEchoFilter>().wetMix = wetMix;
							noteTilesHigh[2,0].color = selectedColor;
						}
						else if (noteTilesHigh[2,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[2][x, y] == false) {
							noteTilesHigh[2,0].color = Color.white;
							SynthSource_34.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesHigh[3,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[3][x, y] == true) {
							SynthSource_35.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_35.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_35.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_35.GetComponent<Oscillator>().frequency = SynthSource_35.GetComponent<Oscillator>().frequencies[35];
							SynthSource_35.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_35.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesHigh[3,0].color = selectedColor;
						}
						else if (noteTilesHigh[3,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[3][x, y] == false) {
							noteTilesHigh[3,0].color = Color.white;
							SynthSource_35.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesHigh[4,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[4][x, y] == true) {
							SynthSource_36.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_36.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_36.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_36.GetComponent<Oscillator>().frequency = SynthSource_36.GetComponent<Oscillator>().frequencies[36];	
							SynthSource_36.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_36.GetComponent<AudioEchoFilter>().wetMix = wetMix;
							noteTilesHigh[4,0].color = selectedColor;
						}
						else if (noteTilesHigh[4,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[4][x, y] == false) {
							noteTilesHigh[4,0].color = Color.white;
							SynthSource_36.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesHigh[5,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[5][x, y] == true) {
							SynthSource_37.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_37.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_37.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_37.GetComponent<Oscillator>().frequency = SynthSource_37.GetComponent<Oscillator>().frequencies[37];
							SynthSource_37.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_37.GetComponent<AudioEchoFilter>().wetMix = wetMix;
							noteTilesHigh[5,0].color = selectedColor;
						}
						else if (noteTilesHigh[5,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[5][x, y] == false) {
							noteTilesHigh[5,0].color = Color.white;
							SynthSource_37.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesHigh[6,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[6][x, y] == true) {
							SynthSource_38.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_38.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_38.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_38.GetComponent<Oscillator>().frequency = SynthSource_38.GetComponent<Oscillator>().frequencies[38];	
							SynthSource_38.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_38.GetComponent<AudioEchoFilter>().wetMix = wetMix;
							noteTilesHigh[6,0].color = selectedColor;
						}
						else if (noteTilesHigh[6,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[6][x, y] == false) {
							noteTilesHigh[6,0].color = Color.white;
							SynthSource_38.GetComponent<Oscillator>().gain = 0;
						}

						if (noteTilesHigh[7,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[7][x, y] == true) {
							SynthSource_39.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_39.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_39.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_39.GetComponent<Oscillator>().frequency = SynthSource_39.GetComponent<Oscillator>().frequencies[39];
							SynthSource_39.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_39.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesHigh[7,0].color = selectedColor;
						}
						else if (noteTilesHigh[7,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[7][x, y] == false) {
							noteTilesHigh[7,0].color = Color.white;
							SynthSource_39.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesHigh[0,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[8][x, y] == true) {
							SynthSource_40.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_40.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_40.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_40.GetComponent<Oscillator>().frequency = SynthSource_40.GetComponent<Oscillator>().frequencies[40];
							SynthSource_40.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_40.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesHigh[0,1].color = selectedColor;
						}
						else if (noteTilesHigh[0,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[8][x, y] == false) {
							noteTilesHigh[0,1].color = Color.white;
							SynthSource_40.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesHigh[1,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[9][x, y] == true) {
							SynthSource_41.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_41.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_41.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_41.GetComponent<Oscillator>().frequency = SynthSource_41.GetComponent<Oscillator>().frequencies[41];
							SynthSource_41.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_41.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesHigh[1,1].color = selectedColor;
						}
						else if (noteTilesHigh[1,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[9][x, y] == false) {
							noteTilesHigh[1,1].color = Color.white;
							SynthSource_41.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesHigh[2,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[10][x, y] == true) {
							SynthSource_42.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_42.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_42.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_42.GetComponent<Oscillator>().frequency = SynthSource_42.GetComponent<Oscillator>().frequencies[42];
							SynthSource_42.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_42.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesHigh[2,1].color = selectedColor;
						}
						else if (noteTilesHigh[2,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[10][x, y] == false) {
							noteTilesHigh[2,1].color = Color.white;
							SynthSource_42.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesHigh[3,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[11][x, y] == true) {
							SynthSource_43.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_43.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_43.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_43.GetComponent<Oscillator>().frequency = SynthSource_43.GetComponent<Oscillator>().frequencies[43];	
							SynthSource_43.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_43.GetComponent<AudioEchoFilter>().wetMix = wetMix;
							noteTilesHigh[3,1].color = selectedColor;
						}
						else if (noteTilesHigh[3,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[11][x, y] == false) {
							noteTilesHigh[3,1].color = Color.white;
							SynthSource_43.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesHigh[4,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[12][x, y] == true) {
							SynthSource_44.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_44.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_44.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_44.GetComponent<Oscillator>().frequency = SynthSource_44.GetComponent<Oscillator>().frequencies[44];
							SynthSource_44.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_44.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesHigh[4,1].color = selectedColor;
						}
						else if (noteTilesHigh[4,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[12][x, y] == false) {
							noteTilesHigh[4,1].color = Color.white;
							SynthSource_44.GetComponent<Oscillator>().gain = 0;
						}		

						if (noteTilesHigh[5,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[13][x, y] == true) {
							SynthSource_44.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_44.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_45.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_45.GetComponent<Oscillator>().frequency = SynthSource_45.GetComponent<Oscillator>().frequencies[45];	
							SynthSource_45.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_45.GetComponent<AudioEchoFilter>().wetMix = wetMix;
							noteTilesHigh[5,1].color = selectedColor;
						}
						else if (noteTilesHigh[5,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[13][x, y] == false) {
							noteTilesHigh[5,1].color = Color.white;
							SynthSource_45.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesHigh[6,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[14][x, y] == true) {
							SynthSource_46.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_46.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_46.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_46.GetComponent<Oscillator>().frequency = SynthSource_46.GetComponent<Oscillator>().frequencies[46];
							SynthSource_46.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_46.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesHigh[6,1].color = selectedColor;
						}
						else if (noteTilesHigh[6,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[14][x, y] == false) {
							noteTilesHigh[6,1].color = Color.white;
							SynthSource_46.GetComponent<Oscillator>().gain = 0;
						}			

						if (noteTilesHigh[7,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[15][x, y] == true) {
							SynthSource_47.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_47.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_47.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_47.GetComponent<Oscillator>().frequency = SynthSource_47.GetComponent<Oscillator>().frequencies[47];
							SynthSource_47.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_47.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesHigh[7,1].color = selectedColor;
						}
						else if (noteTilesHigh[7,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteHigh[15][x, y] == false) {
							noteTilesHigh[7,1].color = Color.white;
							SynthSource_47.GetComponent<Oscillator>().gain = 0;
						}


						/////	



						if (noteTilesSub[0,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[0][x, y] == true) {
							SynthSource_48.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_48.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_48.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_48.GetComponent<Oscillator>().frequency = SynthSource_48.GetComponent<Oscillator>().frequencies[48];
							SynthSource_48.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_48.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesSub[0,0].color = selectedColor;
						}
						else if (noteTilesSub[0,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[0][x, y] == false) {
							noteTilesSub[0,0].color = Color.white;
							SynthSource_48.GetComponent<Oscillator>().gain = 0;
						}

						if (noteTilesSub[1,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[1][x, y] == true) {
                            SynthSource_49.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_49.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_49.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_49.GetComponent<Oscillator>().frequency = SynthSource_49.GetComponent<Oscillator>().frequencies[49];
							SynthSource_49.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_49.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesSub[1,0].color = selectedColor;
						}
						else if (noteTilesSub[1,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[1][x, y] == false) {
							noteTilesSub[1,0].color = Color.white;
							SynthSource_49.GetComponent<Oscillator>().gain = 0;
						}			

						if (noteTilesSub[2,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[2][x, y] == true) {
							SynthSource_50.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_50.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_50.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_50.GetComponent<Oscillator>().frequency = SynthSource_50.GetComponent<Oscillator>().frequencies[50];
							SynthSource_50.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_50.GetComponent<AudioEchoFilter>().wetMix = wetMix;
							noteTilesSub[2,0].color = selectedColor;
						}
						else if (noteTilesSub[2,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[2][x, y] == false) {
							noteTilesSub[2,0].color = Color.white;
							SynthSource_50.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesSub[3,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[3][x, y] == true) {
							SynthSource_51.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_51.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_51.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_51.GetComponent<Oscillator>().frequency = SynthSource_51.GetComponent<Oscillator>().frequencies[51];
							SynthSource_51.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_51.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesSub[3,0].color = selectedColor;
						}
						else if (noteTilesSub[3,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[3][x, y] == false) {
							noteTilesSub[3,0].color = Color.white;
							SynthSource_51.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesSub[4,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[4][x, y] == true) {
							SynthSource_52.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_52.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_52.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_52.GetComponent<Oscillator>().frequency = SynthSource_52.GetComponent<Oscillator>().frequencies[52];	
							SynthSource_52.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_52.GetComponent<AudioEchoFilter>().wetMix = wetMix;
							noteTilesSub[4,0].color = selectedColor;
						}
						else if (noteTilesSub[4,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[4][x, y] == false) {
							noteTilesSub[4,0].color = Color.white;
							SynthSource_52.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesSub[5,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[5][x, y] == true) {
							SynthSource_53.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_53.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_53.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_53.GetComponent<Oscillator>().frequency = SynthSource_53.GetComponent<Oscillator>().frequencies[53];
							SynthSource_53.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_53.GetComponent<AudioEchoFilter>().wetMix = wetMix;
							noteTilesSub[5,0].color = selectedColor;
						}
						else if (noteTilesSub[5,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[5][x, y] == false) {
							noteTilesSub[5,0].color = Color.white;
							SynthSource_53.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesSub[6,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[6][x, y] == true) {
							SynthSource_54.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_54.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_54.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_54.GetComponent<Oscillator>().frequency = SynthSource_54.GetComponent<Oscillator>().frequencies[54];	
							SynthSource_54.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_54.GetComponent<AudioEchoFilter>().wetMix = wetMix;
							noteTilesSub[6,0].color = selectedColor;
						}
						else if (noteTilesSub[6,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[6][x, y] == false) {
							noteTilesSub[6,0].color = Color.white;
							SynthSource_54.GetComponent<Oscillator>().gain = 0;
						}

						if (noteTilesSub[7,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[7][x, y] == true) {
							SynthSource_55.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_55.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_55.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_55.GetComponent<Oscillator>().frequency = SynthSource_55.GetComponent<Oscillator>().frequencies[55];
							SynthSource_55.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_55.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesSub[7,0].color = selectedColor;
						}
						else if (noteTilesSub[7,0] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[7][x, y] == false) {
							noteTilesSub[7,0].color = Color.white;
							SynthSource_55.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesSub[0,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[8][x, y] == true) {
							SynthSource_56.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_56.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_56.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_56.GetComponent<Oscillator>().frequency = SynthSource_56.GetComponent<Oscillator>().frequencies[56];
							SynthSource_56.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_56.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesSub[0,1].color = selectedColor;
						}
						else if (noteTilesSub[0,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[8][x, y] == false) {
							noteTilesSub[0,1].color = Color.white;
							SynthSource_56.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesSub[1,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[9][x, y] == true) {
							SynthSource_57.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_57.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_57.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_57.GetComponent<Oscillator>().frequency = SynthSource_57.GetComponent<Oscillator>().frequencies[57];
							SynthSource_57.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_57.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesSub[1,1].color = selectedColor;
						}
						else if (noteTilesSub[1,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[9][x, y] == false) {
							noteTilesSub[1,1].color = Color.white;
							SynthSource_57.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesSub[2,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[10][x, y] == true) {
							SynthSource_58.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_58.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_58.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_58.GetComponent<Oscillator>().frequency = SynthSource_58.GetComponent<Oscillator>().frequencies[58];
							SynthSource_58.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_58.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesSub[2,1].color = selectedColor;
						}
						else if (noteTilesSub[2,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[10][x, y] == false) {
							noteTilesSub[2,1].color = Color.white;
							SynthSource_58.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesSub[3,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[11][x, y] == true) {
							SynthSource_59.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_59.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_59.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_59.GetComponent<Oscillator>().frequency = SynthSource_59.GetComponent<Oscillator>().frequencies[59];	
							SynthSource_59.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_59.GetComponent<AudioEchoFilter>().wetMix = wetMix;
							noteTilesSub[3,1].color = selectedColor;
						}
						else if (noteTilesHigh[3,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[11][x, y] == false) {
							noteTilesSub[3,1].color = Color.white;
							SynthSource_59.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesSub[4,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[12][x, y] == true) {
							SynthSource_60.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_60.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_60.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_60.GetComponent<Oscillator>().frequency = SynthSource_60.GetComponent<Oscillator>().frequencies[60];
							SynthSource_60.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_60.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesSub[4,1].color = selectedColor;
						}
						else if (noteTilesSub[4,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[12][x, y] == false) {
							noteTilesSub[4,1].color = Color.white;
							SynthSource_60.GetComponent<Oscillator>().gain = 0;
						}		

						if (noteTilesSub[5,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[13][x, y] == true) {
							SynthSource_61.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_61.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_61.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_61.GetComponent<Oscillator>().frequency = SynthSource_61.GetComponent<Oscillator>().frequencies[61];	
							SynthSource_61.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_61.GetComponent<AudioEchoFilter>().wetMix = wetMix;
							noteTilesSub[5,1].color = selectedColor;
						}
						else if (noteTilesSub[5,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[13][x, y] == false) {
							noteTilesSub[5,1].color = Color.white;
							SynthSource_61.GetComponent<Oscillator>().gain = 0;
						}	

						if (noteTilesSub[6,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[14][x, y] == true) {
							SynthSource_62.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_62.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_62.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_62.GetComponent<Oscillator>().frequency = SynthSource_62.GetComponent<Oscillator>().frequencies[62];
							SynthSource_62.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_62.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesSub[6,1].color = selectedColor;
						}
						else if (noteTilesSub[6,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[14][x, y] == false) {
							noteTilesSub[6,1].color = Color.white;
							SynthSource_62.GetComponent<Oscillator>().gain = 0;
						}			

						if (noteTilesSub[7,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[15][x, y] == true) {
							SynthSource_63.GetComponent<Oscillator>().gain = synthVolume;
							SynthSource_63.GetComponent<Oscillator>().pitch = pitch;
							SynthSource_63.GetComponent<Oscillator>().gain2 = gain2;
							SynthSource_63.GetComponent<Oscillator>().frequency = SynthSource_63.GetComponent<Oscillator>().frequencies[63];
							SynthSource_63.GetComponent<AudioEchoFilter>().delay = delay;
							SynthSource_63.GetComponent<AudioEchoFilter>().wetMix = wetMix;	
							noteTilesSub[7,1].color = selectedColor;
						}
						else if (noteTilesSub[7,1] != null && gameObject.name == OperatorManager.instance.tiles[x, y].name && OperatorManager.instance.noteSub[15][x, y] == false) {
							noteTilesSub[7,1].color = Color.white;
							SynthSource_63.GetComponent<Oscillator>().gain = 0;
						}						
						

						//MuteSynth
						if (legatoButton.GetComponent<Toggle>().isOn == true) {
							yield return new WaitForSeconds(nextbeatTime - Time.timeSinceLevelLoad + ms);
                    		SynthSource_0.GetComponent<Oscillator>().gain = 0f;
							SynthSource_1.GetComponent<Oscillator>().gain = 0f;
							SynthSource_2.GetComponent<Oscillator>().gain = 0f;
							SynthSource_3.GetComponent<Oscillator>().gain = 0f;
							SynthSource_4.GetComponent<Oscillator>().gain = 0f;
							SynthSource_5.GetComponent<Oscillator>().gain = 0f;
							SynthSource_6.GetComponent<Oscillator>().gain = 0f;
							SynthSource_7.GetComponent<Oscillator>().gain = 0f;
							SynthSource_8.GetComponent<Oscillator>().gain = 0f;
							SynthSource_9.GetComponent<Oscillator>().gain = 0f;
							SynthSource_10.GetComponent<Oscillator>().gain = 0f;
							SynthSource_11.GetComponent<Oscillator>().gain = 0f;
							SynthSource_12.GetComponent<Oscillator>().gain = 0f;
							SynthSource_13.GetComponent<Oscillator>().gain = 0f;
							SynthSource_14.GetComponent<Oscillator>().gain = 0f;
							SynthSource_15.GetComponent<Oscillator>().gain = 0f;
							SynthSource_16.GetComponent<Oscillator>().gain = 0f;
							SynthSource_17.GetComponent<Oscillator>().gain = 0f;
							SynthSource_18.GetComponent<Oscillator>().gain = 0f;
							SynthSource_19.GetComponent<Oscillator>().gain = 0f;
							SynthSource_20.GetComponent<Oscillator>().gain = 0f;
							SynthSource_21.GetComponent<Oscillator>().gain = 0f;
							SynthSource_22.GetComponent<Oscillator>().gain = 0f;
							SynthSource_23.GetComponent<Oscillator>().gain = 0f;
							SynthSource_24.GetComponent<Oscillator>().gain = 0f;
							SynthSource_25.GetComponent<Oscillator>().gain = 0f;
							SynthSource_26.GetComponent<Oscillator>().gain = 0f;
							SynthSource_27.GetComponent<Oscillator>().gain = 0f;
							SynthSource_28.GetComponent<Oscillator>().gain = 0f;
							SynthSource_29.GetComponent<Oscillator>().gain = 0f;
							SynthSource_30.GetComponent<Oscillator>().gain = 0f;
							SynthSource_31.GetComponent<Oscillator>().gain = 0f;
							SynthSource_32.GetComponent<Oscillator>().gain = 0f;
							SynthSource_33.GetComponent<Oscillator>().gain = 0f;
							SynthSource_34.GetComponent<Oscillator>().gain = 0f;
							SynthSource_35.GetComponent<Oscillator>().gain = 0f;
							SynthSource_36.GetComponent<Oscillator>().gain = 0f;
							SynthSource_37.GetComponent<Oscillator>().gain = 0f;
							SynthSource_38.GetComponent<Oscillator>().gain = 0f;
							SynthSource_39.GetComponent<Oscillator>().gain = 0f;
							SynthSource_40.GetComponent<Oscillator>().gain = 0f;
							SynthSource_41.GetComponent<Oscillator>().gain = 0f;
							SynthSource_42.GetComponent<Oscillator>().gain = 0f;
							SynthSource_43.GetComponent<Oscillator>().gain = 0f;
							SynthSource_44.GetComponent<Oscillator>().gain = 0f;
							SynthSource_45.GetComponent<Oscillator>().gain = 0f;
							SynthSource_46.GetComponent<Oscillator>().gain = 0f;
							SynthSource_47.GetComponent<Oscillator>().gain = 0f;
							SynthSource_48.GetComponent<Oscillator>().gain = 0f;
							SynthSource_49.GetComponent<Oscillator>().gain = 0f;
							SynthSource_50.GetComponent<Oscillator>().gain = 0f;
							SynthSource_51.GetComponent<Oscillator>().gain = 0f;
							SynthSource_52.GetComponent<Oscillator>().gain = 0f;
							SynthSource_53.GetComponent<Oscillator>().gain = 0f;
							SynthSource_54.GetComponent<Oscillator>().gain = 0f;
							SynthSource_55.GetComponent<Oscillator>().gain = 0f;
							SynthSource_56.GetComponent<Oscillator>().gain = 0f;
							SynthSource_57.GetComponent<Oscillator>().gain = 0f;
							SynthSource_58.GetComponent<Oscillator>().gain = 0f;
							SynthSource_59.GetComponent<Oscillator>().gain = 0f;
							SynthSource_60.GetComponent<Oscillator>().gain = 0f;
							SynthSource_61.GetComponent<Oscillator>().gain = 0f;
							SynthSource_62.GetComponent<Oscillator>().gain = 0f;
							SynthSource_63.GetComponent<Oscillator>().gain = 0f;
						}						
																											
						yield return StartCoroutine(Delay());

						hasCoroutineStarted = true;
						UnTriggerWave();	
					}
				}
			}
			hasCoroutineStarted = false;
		}
	}

	void UnTriggerWave() {
		for (int y = 0; y < OperatorManager.instance.ySize; y++) {
			for (int x = 0; x < OperatorManager.instance.xSize; x++) {
				OperatorManager.instance.tiles[x, y].GetComponent<SpriteRenderer>().color = Color.white;
			}
		}
	}

	public IEnumerator Delay() {
		nextbeatTime += ms;
		yield return new WaitForSeconds(nextbeatTime - Time.timeSinceLevelLoad);
	}


	IEnumerator StopShakingCamera() {
		yield return new WaitForSeconds(0.1f);
		mainCamera.GetComponent<CameraShake>().stopshakingcamera();
	}

	IEnumerator resetflipTile() {
		yield return new WaitForSeconds(1f);
		GetComponent<RotateYaxis>().resetflipTile();
	}	

	IEnumerator StopNote() {
		yield return new WaitForSeconds(ms);
		Oscillator1.GetComponent<Oscillator>().gain = 0;
	}		
}