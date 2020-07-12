using UnityEngine.Audio;
using System;
using UnityEngine;

public class audiomaneger : MonoBehaviour
{
    public Audio[] sounds;
    void Awake()
    {
        foreach (Audio s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    void Start()
    {
        Play("Test");
    }

    public void Play (string name)
    {
       Audio s = Array.Find(sounds, sound => sound.name == name);
       s.source.Play();
    }
}
