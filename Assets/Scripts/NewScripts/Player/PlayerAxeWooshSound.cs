using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAxeWooshSound : MonoBehaviour
{

    //get audio source
    [SerializeField]
    private AudioSource audioSource;


    //wooshSound
    [SerializeField]
    private AudioClip[] woosh_Sounds;


    //play woosh 
    void PlayWooshSound()
    {
        audioSource.clip = woosh_Sounds[Random.Range(0, woosh_Sounds.Length)];
        audioSource.Play();
    }

}
