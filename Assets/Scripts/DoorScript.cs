using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool doorActive = false;
    Collider m_Collider;
    public static string voiceRec = "";

    void Start()
    {
        //Fetch the GameObject's Collider (make sure it has a Collider component)
        m_Collider = GetComponent<BoxCollider>();
    }

    void Update()
    {
        if (doorActive == true)
        {
            //Toggle the Collider on and off when pressing the space bar
            m_Collider.enabled = !m_Collider.enabled;

            //Output to console whether the Collider is on or not
            Debug.Log("Collider.enabled = " + m_Collider.enabled);
        }
    }




    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("OutSide");
    }

}


