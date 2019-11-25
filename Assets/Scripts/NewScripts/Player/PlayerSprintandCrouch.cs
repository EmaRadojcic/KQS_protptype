using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprintandCrouch : MonoBehaviour
{

    private PlayerMovement playerMovement;

    //how fast player moves while sprinting
    public float sprint_Speed = 10f;
    //how fast player moves while walking
    public float move_Speed = 5f;
    //how fast player moves while crouching
    public float crouch_Speed = 2f;

    private Transform look_Root;
    private float stand_Height = 1.6f;
    //height of camera when crouched
    private float crouch_Height = 1f;

    private bool is_Crouching;

    //gets footep audio form player
    private PlayerFootsteps player_Footsteps;

    //sound variations depending on how fast player is going 
    private float sprint_Volume = 1f;
    private float crouch_Volume = 0.1f;
    private float walk_Volume_Min = 0.2f, walk_Volume_Max = 0.6f;

    private float walk_Step_Distance = 0.4f;
    private float sprint_Step_Distance = 0.25f;
    private float crouch_Step_Distance = 0.5f;
    private PlayerStats player_Stats;

    private float sprint_Value = 100f;
    public float sprint_Treshold = 10f;

    void Awake()
    {

        playerMovement = GetComponent<PlayerMovement>();

        //first child of lookroot(player) 
        look_Root = transform.GetChild(0);

        player_Footsteps = GetComponentInChildren<PlayerFootsteps>();

         player_Stats = GetComponent<PlayerStats>();

    }

    //staring footstep sounds
    void Start()
    {
         player_Footsteps.volume_Min = walk_Volume_Min;
          player_Footsteps.volume_Max = walk_Volume_Max;
      player_Footsteps.step_Distance = walk_Step_Distance;
    }

    // Update is called once per frame
    void Update()
    {
        Sprint();
        Crouch();
    }

    //if holding down shift and not crouching
    void Sprint()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && !is_Crouching)
        {
            playerMovement.speed = sprint_Speed;

        }
        
        //if we have stamina we can sprint
        if (sprint_Value > 0f)
        {
  
             if (Input.GetKeyDown(KeyCode.LeftShift) && !is_Crouching)
               {

                playerMovement.speed = sprint_Speed;
                player_Footsteps.volume_Min = sprint_Volume;

                player_Footsteps.volume_Max = sprint_Volume;
                player_Footsteps.step_Distance = sprint_Step_Distance;
               

            }

        }
        



        //if lifting shift and not crouching 
        if (Input.GetKeyUp(KeyCode.LeftShift) && !is_Crouching)
        {
            //resets everything 
            playerMovement.speed = move_Speed;

            player_Footsteps.step_Distance = walk_Step_Distance;
            player_Footsteps.volume_Min = walk_Volume_Min;
           player_Footsteps.volume_Max = walk_Volume_Max;

        }




        if (Input.GetKey(KeyCode.LeftShift) && !is_Crouching)
        {

                sprint_Value -= sprint_Treshold * Time.deltaTime;

            if (sprint_Value <= 0f)
              {

                sprint_Value = 0f;

                // reset the speed and sound back to walking 

                player_Footsteps.volume_Min = walk_Volume_Min;
                player_Footsteps.volume_Max = walk_Volume_Max;

                playerMovement.speed = move_Speed;
                 player_Footsteps.step_Distance = walk_Step_Distance;
              

            }

         player_Stats.Display_StaminaStats(sprint_Value);

        }
        else
        {

            if (sprint_Value != 100f)
            {
                //generates sprintvalue back up by 10 every two secs
                sprint_Value += (sprint_Treshold / 2f) * Time.deltaTime;

                     player_Stats.Display_StaminaStats(sprint_Value);

                if (sprint_Value > 100f)
                {

                    sprint_Value = 100f;
                }

            }

        }


    }



    //crouching
    void Crouch()
    {

        //if holding down r key then player is crouching

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (is_Crouching)
            {
                
                //if already crouching then resets backs to walking variables
                look_Root.localPosition = new Vector3(0f, stand_Height, 0f);
                playerMovement.speed = move_Speed;

               player_Footsteps.step_Distance = walk_Step_Distance;
               player_Footsteps.volume_Min = walk_Volume_Min;
              player_Footsteps.volume_Max = walk_Volume_Max;


                //crouch set to false
                is_Crouching = false;

            }
            else
            { 
                //else then player is crouching and all crouching sounds and speeds are set for the player and the camera height is lowered
                look_Root.localPosition = new Vector3(0f, crouch_Height, 0f);
                playerMovement.speed = crouch_Speed;

               player_Footsteps.step_Distance = crouch_Step_Distance;
               player_Footsteps.volume_Min = crouch_Volume;
                  player_Footsteps.volume_Max = crouch_Volume;
              

                //sets crouching to true
                is_Crouching = true;

            }

        }


    }

}
