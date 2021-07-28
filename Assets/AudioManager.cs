using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound [] sounds;

    public static AudioManager instance;


    private void Awake()
    {

        DontDestroyOnLoad(gameObject);

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        foreach (Sound item in sounds)
        {
            item.audioSource = gameObject.gameObject.AddComponent<AudioSource>();
            item.audioSource.clip = item.audioClip;
            item.audioSource.volume = item.volume;
            item.audioSource.pitch = item.pitch;
            item.audioSource.loop = item.loop;


        }
    }
    private void Start()
    {
        PlayAudio("BackGround");
    }
    public void StopPlayAudio(string name)
    {
        Sound s = Array.Find(sounds, Sounds => Sounds.audioName == name);
        if (s == null)
        {
            Debug.LogWarning("Hey Audioname" + name + "Not Found");
            return;
        }
        s.audioSource.Stop();
    }
    public void PlayAudio(string name)
    {
        Sound s= Array.Find(sounds, Sound => Sound.audioName == name);
        if (s == null)
        {
            Debug.LogWarning("Hey audioname" + name + "Not found");
            return;

        }
        s.audioSource.Play();
    }
    public void SetVolume(string name,float volumeValue)
    {
        Sound s = Array.Find(sounds, Sound => Sound.audioName == name);
        if (s == null)
        {
            Debug.LogWarning("Hey audioname" + name + "Not found");
            return;

        }
        else
        {
            s.audioSource.volume = volumeValue;
        }
       

    }
    
}
