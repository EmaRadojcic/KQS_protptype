using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour, IDamageable
{
    //allows user to edit enemystats+ healthbarslider
    [SerializeField] private EnemyStats enemyStats;
    [SerializeField] private Slider healthbarSlider;
    [SerializeField] private Image healthbarFillImage;
    [SerializeField] private Color maxHealthColor;
    [SerializeField] private Color zeroHealthColor;


    private int currentHealth;

    private void Start()
    {
        //finds max health on enemeny in enemystats
        currentHealth = enemyStats.maxHealth;
        //starts healthbar UI
        setHealthBarUI();
    }
    public void DealDamage(int damage)
    {
        //changes current health if damage has been done
        currentHealth -= damage;
        //cheecks if health is 0
        checkIfDead();
        setHealthBarUI();
    }

    //if health reaches 0 then game object is destroyed 
    private void checkIfDead() {
        if (currentHealth <= 0) {
            //destorys current object
            Destroy(gameObject);
            CollectSystem.killEnemies += 1;
        }
    }

    //health br slider adjusment
    private void setHealthBarUI() {
        float healthpercentage = CalculateHealthPercentage();
        healthbarSlider.value = healthpercentage;
        healthbarFillImage.color = Color.Lerp(zeroHealthColor,maxHealthColor,healthpercentage/100);
    }

    //calculates value for health bar slider
    private float CalculateHealthPercentage(){
       return ((float)currentHealth / (float)enemyStats.maxHealth) * 100;

}

}

