using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotCollect : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        CollectSystem.potCollect += 1;
        Destroy(gameObject);

    }
}
