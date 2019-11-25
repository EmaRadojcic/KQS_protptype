using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMngr : MonoBehaviour
{
    public static string voiceRec = "";

    void Update()
    {
 
        CheckForSpeech();
    }

    private void CheckForSpeech()
    {
        if (voiceRec == "play" || (Input.GetMouseButtonDown(0)))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("HouseV3");
        }

        if (voiceRec == "quit")
        {
            Application.Quit();
        }
    }


}
