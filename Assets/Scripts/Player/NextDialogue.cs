using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextDialogue : MonoBehaviour
{
    [SerializeField] private DialogueManager DialogueMng;

    public void NextSentence() {
        DialogueMng.DisplayNextSentence();
    }

}
