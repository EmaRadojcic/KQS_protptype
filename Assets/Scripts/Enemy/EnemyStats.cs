using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy Stats", menuName = "Enemy/Stats")]
public class EnemyStats : ScriptableObject
{
    public new string enemyName;
    public int maxHealth;
}
