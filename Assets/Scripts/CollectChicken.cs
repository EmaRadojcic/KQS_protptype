using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectChicken : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        CollectSystem.theScore += 1;
        Destroy(gameObject);

    }
}
