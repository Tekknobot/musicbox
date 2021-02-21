﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
    public static MusicPlayer instance;

    public enum SeekDirection { Forward, Backward }
    
    public AudioSource source;
    public List<AudioClip> clips = new List<AudioClip>();
    public List<float> chopTime = new List<float>();
    public List<AudioClip> song = new List<AudioClip>();

    public AudioClip scratch;
    
    [SerializeField] [HideInInspector] public int currentIndex = 0;
    
    private FileInfo[] soundFiles;
    private List<string> validExtensions = new List<string> { ".ogg", ".wav" }; // Don't forget the "." i.e. "ogg" won't work - cause Path.GetExtension(filePath) will return .ext, not just ext.
    private string absolutePath = "./"; // relative path to where the app is running - change this to "./music" in your case

    public Button previous;
    public Button play;
    public Button next;
    public Button reload;
    public Button chop;
    public Button clear;

    public AudioSource audioSource;
    public Slider slider;

    public int i;

    private static string GetAndroidExternalFilesDir()
    {
        using (AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        {
            using (AndroidJavaObject context = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity"))
            {
                // Get all available external file directories (emulated and sdCards)
                AndroidJavaObject[] externalFilesDirectories = context.Call<AndroidJavaObject[]>("getExternalFilesDirs", (object[])null);
                AndroidJavaObject emulated = null;
                AndroidJavaObject sdCard = null;

                for (int i = 0; i < externalFilesDirectories.Length; i++)
                {
                        AndroidJavaObject directory = externalFilesDirectories[i];
                        using (AndroidJavaClass environment = new AndroidJavaClass("android.os.Environment"))
                        {
                            // Check which one is the emulated and which the sdCard.
                            bool isRemovable = environment.CallStatic<bool> ("isExternalStorageRemovable", directory);
                            bool isEmulated = environment.CallStatic<bool> ("isExternalStorageEmulated", directory);
                            if (isEmulated)
                                emulated = directory;
                            else if (isRemovable && isEmulated == false)
                                sdCard = directory;
                        }
                }
                // Return the sdCard if available
                if (sdCard != null)
                        return sdCard.Call<string>("getAbsolutePath");
                else
                        return emulated.Call<string>("getAbsolutePath");
                }
        }
    }    

    void Awake()
    {
        //if (GameObject.FindGameObjectsWithTag("MusicPlayer").Length > 1) Destroy(GameObject.FindGameObjectWithTag("MusicPlayer"));
        //DontDestroyOnLoad(gameObject);

        //being able to test in unity
        if (Application.isEditor) absolutePath = "C:/Unity Projects/KontrolSongs";

        //GameObject.Find ("PATH").GetComponent<Text>().text = GetAndroidExternalFilesDir().ToString();
    
        if (source == null) source = gameObject.AddComponent<AudioSource>();
    
        previous.onClick.AddListener(previousTaskOnClick);
        play.onClick.AddListener(playTaskOnClick);
        next.onClick.AddListener(nextTaskOnClick);
        reload.onClick.AddListener(reloadTaskOnClick);

        chop.onClick.AddListener(chopTaskOnClick);
        clear.onClick.AddListener(clearTaskOnClick);

        ReloadSounds();
    }
 
    public void ChangeAudioTime()
    {
        audioSource.time = audioSource.clip.length * slider.value;
    }
 
    public void Update()
    {
        if (audioSource) {
            if (audioSource.isPlaying) {
                slider.value = audioSource.time / audioSource.clip.length;
            }
        }
    }    
    
    void previousTaskOnClick() {
        Seek(SeekDirection.Backward);
        PlayCurrent();
    }

    void playTaskOnClick() {
        PlayCurrent();
    }  

    void nextTaskOnClick() {
        Seek(SeekDirection.Forward);
        PlayCurrent();
    }    

    void reloadTaskOnClick() {
        ReloadSounds();
    }     

    void chopTaskOnClick() {
        chopTime.Add(audioSource.time);
        song.Add(clips[currentIndex]);
        GameObject.Find("ChopCount").GetComponent<Text>().text = chopTime.Count.ToString();
        if (chopTime.Count > 16) {
            GameObject.Find("ChopCount").GetComponent<Text>().color = Color.red;
        }  
    }  

    void clearTaskOnClick() {        
        GameObject.Find("ChopCount").GetComponent<Text>().text = "0";
        GameObject.Find("ChopCount").GetComponent<Text>().color = Color.white; 
        // GameObject.Find("MusicPlayer").GetComponent<MusicPlayer>().chopTime.Clear();
        // GameObject.Find("MusicPlayer").GetComponent<MusicPlayer>().song.Clear();       
        StopCurrent();
    }      
    
    void Seek(SeekDirection d)
    {
        if (d == SeekDirection.Forward)
            currentIndex = (currentIndex + 1) % clips.Count;
        else {
            currentIndex--;
            if (currentIndex < 0) currentIndex = clips.Count - 1;
        }
    }
    
    void PlayCurrent()
    {
        source.clip = clips[currentIndex];
        source.Play();
        GameObject.Find ("FileName").GetComponent<Text>().text = source.clip.name.ToString();
    }

    void StopCurrent()
    {
        source.clip = clips[currentIndex];
        source.Stop();
        GameObject.Find ("FileName").GetComponent<Text>().text = source.clip.name.ToString();
    }    
    
    void ReloadSounds()
    {
        clips.Clear();
        // get all valid files
        //var info = new DirectoryInfo(absolutePath);
        var info = new DirectoryInfo(GetAndroidExternalFilesDir());
        soundFiles = info.GetFiles()
            .Where(f => IsValidFileType(f.Name))
            .ToArray();
    
        // and load them
        foreach (var s in soundFiles)
            StartCoroutine(LoadFile(s.FullName));
    }
    
    bool IsValidFileType(string fileName)
    {
        return validExtensions.Contains(Path.GetExtension(fileName));
        // Alternatively, you could go fileName.SubString(fileName.LastIndexOf('.') + 1); that way you don't need the '.' when you add your extensions
    }
    
    IEnumerator LoadFile(string path)
    {
        WWW www = new WWW("file://" + path);
        print("loading " + path);
    
        AudioClip clip = www.GetAudioClip(false);
        while(!clip.isReadyToPlay)
            yield return www;
    
        print("done loading");
        clip.name = Path.GetFileName(path);
        clips.Add(clip);
    }
}