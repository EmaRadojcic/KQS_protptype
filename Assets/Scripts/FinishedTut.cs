using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishedTut : MonoBehaviour
{
     [SerializeField] public GameObject gameObj;

    // Update is called once per frame
    void Update()
    {
      
    }

    void isFinished() {
        if (Raycasting.hasFinishedTut == true) {
            gameObj.SetActive(true);
        }
    }
}
