using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Villager1Script : MonoBehaviour
{

    [SerializeField] private DialogueTrigger DTVillager;
    public GameObject text;

    private void OnTriggerEnter(Collider other)
    {
        DTVillager.TriggerDialouge();
    }


    private void OnTriggerExit(Collider other)
    {
        text.GetComponent<Text>().text = "Walk And Talk to the villagers";

    }


}
