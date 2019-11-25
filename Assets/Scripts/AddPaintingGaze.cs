using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPaintingGaze : MonoBehaviour
{
    [SerializeField]  public GameObject painting;

    public void ActivatePainting()
    {
        painting.SetActive(true);
    }
}
