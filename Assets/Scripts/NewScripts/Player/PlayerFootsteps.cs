using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerFootsteps : MonoBehaviour
{
    //get audio source for footstep
    private AudioSource footstep_Sound;


    //player controller 
    private CharacterController character_Controller;


    //change sounds of footstep 
    [HideInInspector]
    public float volume_Min, volume_Max;



    //get footstep audio to drag and drop
    [SerializeField]
    private AudioClip[] footstep_Clip;

    //how far character goes once footstep sound starts
    private float accumulated_Distance;

    [HideInInspector]
    //change distance depending on how fast player is moving 
    public float step_Distance;




    void Awake()
    {
        //gets audio componenet 
        footstep_Sound = GetComponent<AudioSource>();
        //gets p[layer controller 
        character_Controller = GetComponentInParent<CharacterController>();
    }

    void Update()
    {
        CheckToPlayFootstepSound();
    }




    void CheckToPlayFootstepSound()
    {

        // if we are jumping if not then foot step wont work 
        if (!character_Controller.isGrounded)
            return;




        //if moving then velocity will be >0 
        if (character_Controller.velocity.sqrMagnitude > 0)
        {
            //how far we can go before sound starts;
            accumulated_Distance += Time.deltaTime;

            if (accumulated_Distance > step_Distance)
            {



                //random range for volume
                footstep_Sound.volume = Random.Range(volume_Min, volume_Max);
                //random footsteps soun length 
                footstep_Sound.clip = footstep_Clip[Random.Range(0, footstep_Clip.Length)];
                footstep_Sound.Play();

                accumulated_Distance = 0f;

            }

        }
        else
        {
            //reset accumalted distance 
            accumulated_Distance = 0f;
        }
    }
}