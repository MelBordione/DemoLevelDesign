using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Options : MonoBehaviour
{
    public AudioMixer audiomix;

    public void MusicVolume(float volume)
    {
        audiomix.SetFloat("Volume", volume);
    }
}
