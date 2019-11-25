using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    public AudioSource m_MyAudioSource;
    bool m_ToggleChange;
    bool m_Play;
    // Start is called before the first frame update
    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
        //Ensure the toggle is set to true for the music to play at start-up
        m_Play = true;
    }

    // Update is called once per frame
    void Update()
    {
            if ((Input.GetMouseButtonDown(0)))
            {
                //Play the audio you attach to the AudioSource component
                m_MyAudioSource.Play();
                //Ensure audio doesn’t play more than once
                m_ToggleChange = false;
            }
        }
  
}

