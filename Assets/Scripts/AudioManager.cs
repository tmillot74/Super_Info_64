using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Music", volume);

    }

    public void SetEffect(float volume)
    {
        audioMixer.SetFloat("SoundEffect", volume);

    }
}
