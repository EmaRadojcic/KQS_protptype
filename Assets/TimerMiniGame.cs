using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerMiniGame : MonoBehaviour
{
    public bool timeStart = false;
    float totalTime = 120f; //2 minutes
    public GameObject timerText;
    private void Update()
    {
        if (timeStart == true)
        {
            totalTime -= Time.deltaTime;
            UpdateLevelTimer(totalTime);

            if (CollectSystem.shootingMiniGame == 3)
            {
                timeStart = false;
            }

            if(totalTime == 0)
            {
                Debug.Log("CHANGE SCENE");
                timeStart = false;
            }
        }
    }

    public void StartTime()
    {
        //start game whenlooks at button
        timeStart = true;
       
    }

    public void UpdateLevelTimer(float totalSeconds)
    {
        int minutes = Mathf.FloorToInt(totalSeconds / 60f);
        int seconds = Mathf.RoundToInt(totalSeconds % 60f);

        string formatedSeconds = seconds.ToString();

        if (seconds == 60)
        {
            seconds = 0;
            minutes += 1;
        }

        timerText.GetComponent<Text>().text = minutes.ToString("00") + ":" + seconds.ToString("00"); ;
    }
}
