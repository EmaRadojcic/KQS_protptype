using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSOund : MonoBehaviour
{
    public Transform vrCamera;
    public float toggleAngle = 30.0f;
    public AudioSource m_MyAudioSource;



    private CharacterController cc;


    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
        cc = GetComponent<CharacterController>();
    }


    void Update()
    {
        if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
        {
            m_MyAudioSource.Play();
        }
    }



}

