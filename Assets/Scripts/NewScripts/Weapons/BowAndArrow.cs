using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowAndArrow : MonoBehaviour
{
    //give force to arrow
    private Rigidbody myBody;


    //speed of arrow
    public float speed = 30f;


    //when arrow dies
    public float deactivate_Timer = 2f;

    //how much it damages
    public float damage = 50f;

    void Awake()
    {
        myBody = GetComponent<Rigidbody>();
    }

    // Use this for initialization
    void Start()
    {

        //calls  function after the timer
        Invoke("DeactivateGameObject", deactivate_Timer);
    }


    //fires arrow
    public void Launch(Camera mainCamera)
    {

        myBody.velocity = mainCamera.transform.forward * speed;
        //changes roat
        transform.LookAt(transform.position + myBody.velocity);

    }

    void DeactivateGameObject()
    {
        if (gameObject.activeInHierarchy)
        {
            gameObject.SetActive(false);
        }
    }


    //detects when arrow touches enemy
    void OnTriggerEnter(Collider target)
    {

       

        if (target.tag == "Enemy")
        {

           // target.GetComponent<HealthScript>().ApplyDamage(damage);


            //after arrow touches enemy then the arrow is deactivated 
            gameObject.SetActive(false);

        }

    }

}
