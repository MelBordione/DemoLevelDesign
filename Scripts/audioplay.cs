using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioplay : MonoBehaviour
{
    AudioSource spikeSound;
    AudioSource DoorOpen;
    AudioSource SawSound;

    // Start is called before the first frame update
    void Start()
    {
        spikeSound = GetComponent<AudioSource>();
        DoorOpen = GetComponent<AudioSource>();
        SawSound = GetComponent<AudioSource>();


    }

    public void playsoundSpike()
    {
        spikeSound.Play();
    }

    public void PlaySoundDoor()
    {
        DoorOpen.Play();
    }

    public void PlaySawSound()
    {
        SawSound.Play();
    }



    

    // Update is called once per frame
   
}
