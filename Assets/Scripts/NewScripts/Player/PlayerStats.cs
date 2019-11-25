using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{

    //get stats bars
    [SerializeField]
    private Image health_Stats, stamina_Stats;

    public void Display_HealthStats(float healthValue)
    {

        //bar depletes deping on how much health there is
        healthValue /= 100f;

        health_Stats.fillAmount = healthValue;

    }

    //bar depletes deping on how much stanima there is
    public void Display_StaminaStats(float staminaValue)
    {

        staminaValue /= 100f;

        stamina_Stats.fillAmount = staminaValue;

    }

}
