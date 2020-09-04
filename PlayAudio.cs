using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayAudio : MonoBehaviour
{

    public AudioClass[] sounds;

    float minPitch = .95f;
    float maxPitch = 1.05f;

    public void AudioNewPlay(string name)
    {
        AudioClass s = System.Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }

        int clipIndex = Random.Range(0, s.Clip.Length);

        s.source = gameObject.AddComponent<AudioSource>();
        s.source.clip = s.Clip[clipIndex];
        s.source.volume = s.volume;
        s.pitch = Random.Range(minPitch, maxPitch);
        s.source.priority = s.priority;
        s.source.loop = s.loop;
        s.source.outputAudioMixerGroup = s.output;

        s.source.Play();

        Destroy(s.source, s.Clip[clipIndex].length);
    }

}