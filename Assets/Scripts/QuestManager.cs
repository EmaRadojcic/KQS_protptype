using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    public GameObject textQuest;
    public static  int hasCompleteQuest;
    // Update is called once per frame
    void Update()
    {
        textQuest.GetComponent<Text>().text = "Quests done  " +  hasCompleteQuest.ToString() + " /5";

        if(hasCompleteQuest == 5)
        {
            SceneManager.LoadScene("EndProtoype");
            hasCompleteQuest += 1;
        }
    }

   
}
