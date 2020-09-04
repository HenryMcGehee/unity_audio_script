using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


[System.Serializable]

public class AudioClass
{
    public string name;

    public AudioClip[] Clip;

    public bool loop;

    [Range(0f, 1f)]
    public float volume;

    [Range(-2f, 2f)]
    public float pitch;

    [Range(0, 256)]
    public int priority;

    public AudioMixerGroup output;

    [HideInInspector]
    public AudioSource source;
}


