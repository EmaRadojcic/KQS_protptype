using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveScene : MonoBehaviour
{
    // Start is called before the first frame update
    public  void OpenScene() { 
        //Open the Scene in the Editor (do not enter Play Mode)
         SceneManager.LoadScene("TestScene1");
    }
}
