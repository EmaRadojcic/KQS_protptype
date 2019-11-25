using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HealthScript : MonoBehaviour
{

    //instance variables 
    private EnemyAnimator enemy_Anim;
    private NavMeshAgent navAgent;
    private EnemyController enemy_Controller;


    public float health = 100f;

    public bool is_Player, is_Skellin;

    private bool is_Dead;

    private EnemyAudio enemyAudio;

     private PlayerStats player_Stats;

    void Awake()
    {

        if (is_Skellin)
        {
            enemy_Anim = GetComponent<EnemyAnimator>();
            enemy_Controller = GetComponent<EnemyController>();
            navAgent = GetComponent<NavMeshAgent>();

            // get enemy audio
            enemyAudio = GetComponentInChildren<EnemyAudio>();
        }

        if (is_Player)
        {
           player_Stats = GetComponent<PlayerStats>();
        }

    }

    public void ApplyDamage(float damage)
    {

        // if we died don't execute the rest of the code
        if (is_Dead)
            return;

        health -= damage;

        if (is_Player)
        {
            // show stats
            player_Stats.Display_HealthStats(health);
        }

        if (is_Skellin)
        {
            if (enemy_Controller.Enemy_State == EnemyState.PATROL)
            {
                enemy_Controller.chase_Distance = 60f;
            }
        }

        if (health <= 0f)
        {
            PlayerDied();

            is_Dead = true;
        }

    }


    void PlayerDied()
    {

        if (is_Skellin) 
        {
            GetComponent<Animator>().enabled = false;
            GetComponent<BoxCollider>().isTrigger = false;
            GetComponent<Rigidbody>().AddTorque(-transform.forward * 5f);

            enemy_Controller.enabled = false;
            navAgent.enabled = false;
            enemy_Anim.enabled = false;

            StartCoroutine(DeadSound());

            // EnemyManager spawn more enemies
            //EnemyManager.instance.EnemyDied(true);
        }
        if (is_Player)
        {

          
            
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].GetComponent<EnemyController>().enabled = false;
            }

            // call enemy manager to stop spawning enemis
         //   EnemyManager.instance.StopSpawning();

                    GetComponent<PlayerMovement>().enabled = false;
                    GetComponent<PlayerAttack>().enabled = false;
                    GetComponent<WeaponManager>().GetCurrentSelectedWeapon().gameObject.SetActive(false);

        }

        if (tag == "Player")
        {

            RestartGame();

        }
        else
        {

            TurnOffGameObject();

        }

    } // player died

    void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("PlayerTestV1");
    }

    void TurnOffGameObject()
    {
             gameObject.SetActive(false);



       
    }

    IEnumerator DeadSound()
    {
        yield return new WaitForSeconds(0.3f);
        enemyAudio.Play_DeadSound();
    }
}
