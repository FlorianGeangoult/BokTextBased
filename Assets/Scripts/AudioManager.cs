﻿using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;
    public static AudioManager instance;

    void Awake()
    {

        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.outputAudioMixerGroup = s.group;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.mute = s.mute;
            s.source.loop = s.loop;
        }
    }


    void Start ()
    {
        Play("MusiqueMenu");
    }

   public void Play (string name)
    {
      Sound s =  Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.Log("La musique" + name + "n'a pas été trouvée");
            return;
        }
        

        if (PauseMenu.JeuEnPause)
        {
            s.source.pitch *= .5f;
        }
        if(PauseMenu.JeuEnPause = false)
        {
            s.source.pitch = s.pitch;
        }

        s.source.Play();
    }

    public void StopPlaying(string sound)
    {
        Sound s = Array.Find(sounds, item => item.name == sound);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }

        

        s.source.Stop();
    }

}



