using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningLogo : MonoBehaviour
{
    [SerializeField] public GameObject logo;
    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(7);
        DestroyGameObject();
    }

    void DestroyGameObject()
    {
        Destroy(logo);
    }
}
