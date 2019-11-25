using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Riddle : MonoBehaviour
 
{

    private void Update()
    {
        if(riddleArea ==true && anw == "nothing")
        {
            CollectSystem.riddle += 1;
            Debug.Log("test");
        }
    }
    private bool riddleArea = false;
    public static string anw = "";
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
         riddleArea = true;

    }

    private void OnTriggerExit(Collider other)
    {
        riddleArea = true;
    }
}
