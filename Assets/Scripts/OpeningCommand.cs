using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningCommand : MonoBehaviour
{
    private bool isOnOpenScene = true;
    public static string voice;

    private void Update()
    {
        if (voice == "start" && isOnOpenScene ==true) {
            SceneManager.LoadScene("HouseV2");
            isOnOpenScene = false;
        }
    }




}
