using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasScript : MonoBehaviour
{

public void GoToMiniGame()
    {
        SceneManager.LoadScene("ShootingMiniGame");
    }
}
