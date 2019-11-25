using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private bool isPaused;
    [SerializeField] private UnityEngine.UI.Button btnBack;
    [SerializeField] private UnityEngine.UI.Button btnQuit;
    public GameObject gameObj;
    public static string voiceRec = "";

    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (voiceRec == "menu")
        {
            isPaused = true;

        }

        if (voiceRec == "quit" && isPaused == true)
        {
            Application.Quit();

        }

        if (voiceRec == "back" && isPaused == true)
            {
                isPaused = false;

            }
      
        if (isPaused)
        {
            //pauses game stops time 
          
            ActivateMenu();
        }
        else {
            //starts time again
      
            DeActivateMenu();
        }

    }

  
                           
    void ActivateMenu() {
        pauseMenuUI.SetActive(true);
    }

    void DeActivateMenu() {
        pauseMenuUI.SetActive(false);
    }

}
