using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{


    public float damage = 1f;
    public float radius = 1f;
    public LayerMask layerMask;

    void Update()
    {

        Collider[] hits = Physics.OverlapSphere(transform.position, radius, layerMask);

        if (hits.Length > 0)
        {

                                                                                                             
            Debug.Log("attacked player");
            //applies damage to the enemy via the health script
           hits[0].gameObject.GetComponent<HealthScript>().ApplyDamage(damage);

            gameObject.SetActive(false);

        }

    }
}
