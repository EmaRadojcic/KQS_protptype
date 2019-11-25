using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectSystem : MonoBehaviour
{

    public static int theScore;
    public static int potCollect;
    public static int shootingMiniGame;
    public static int killEnemies;
    public static int riddle;
    void Update()
    {
        Debug.Log(theScore);

        if(theScore == 5)
        {
            QuestManager.hasCompleteQuest += 1;
            theScore += 1;
            
        }
        if (potCollect == 1)
        {
            QuestManager.hasCompleteQuest += 1;
            potCollect += 1;

        }

        if(shootingMiniGame == 4)
        {
            QuestManager.hasCompleteQuest += 1;
            SceneManager.LoadScene("OutSide");
            shootingMiniGame += 1;

        }

        if (killEnemies == 2)
        {
            QuestManager.hasCompleteQuest += 1;
            killEnemies += 1;
            Debug.Log("enemies dded");

        }

        if (riddle == 1)
        {
            QuestManager.hasCompleteQuest += 1;
            killEnemies += 1;
            Debug.Log("riddle");

        }

    }
}
