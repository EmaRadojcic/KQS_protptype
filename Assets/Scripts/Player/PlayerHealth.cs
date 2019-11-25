using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//monitor players health 
public class PlayerHealth : MonoBehaviour
{

    public GameManager manager;
    public Slider healthBar;
    public float health = 100f;

    private void Start()
    {
        healthBar.maxValue = health;
        healthBar.value = health;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            TakeDamage(10f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Enemy")
        {
            Debug.Log("Collision Works");
            TakeDamage(10f);
        }
    }


    public void TakeDamage(float amnt)
    {
        health -= amnt;
        if (health <= 0f)
        {
            SceneManager.LoadScene("MainMenu");
        }
        float _h = Mathf.Clamp(health, 0, 100f);
        healthBar.value = _h;
    }
}