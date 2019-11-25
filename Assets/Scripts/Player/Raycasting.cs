using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour
{
    [SerializeField] private DialogueManager Dg;
    [SerializeField] private DialogueTrigger DgMenu;



    public GameObject bird;

    public static string voiceRec = "";
    public static bool hasStartedTut = false;
    public static bool hasDonePic = false;
    public static bool hasActivatedMenu = false;
    public static bool hasFinishedTut = false;
    public static bool hasWalked = false;

    private bool hasSaidBack = false;
    private bool hasSaidChange = false;

    // Update is called once per frame
    void Update()
    {
        //check to ee if player is shooting
        //CheckForShooting();
        CheckForSpeech();
    }
    //checks to see if player is shooting
    private void CheckForSpeech()
    {
        if (voiceRec == "shoot" || (Input.GetMouseButtonDown(0) ) )
        {
            RaycastHit whatIHit;
            if (Physics.Raycast(transform.position, transform.forward, out whatIHit, Mathf.Infinity))
            {
                IDamageable damageable = whatIHit.collider.GetComponent<IDamageable>();
                if (damageable != null)
                {
                    damageable.DealDamage(70);
                    voiceRec = "";
                }
            }
        }

        if (voiceRec == "change")
        {
            DgMenu.TriggerDialouge();
            voiceRec = "";
            hasStartedTut = true;
        }


        if (voiceRec == "back")
        {
            DoorScript.doorActive = true;
            Dg.DisplayNextSentence();
        }

  

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
            {

                RaycastHit whatIHit;
                if (Physics.Raycast(transform.position, transform.forward, out whatIHit, Mathf.Infinity))
                {
                    if (whatIHit.collider.tag == "Bird")
                    {
                        CollectSystem.shootingMiniGame += 1;
                        bird = whatIHit.collider.gameObject;
                        Debug.Log("cube");
                        Destroy(bird);

                        return;

                    }
                }
            }
        }
    }

               
    
}

