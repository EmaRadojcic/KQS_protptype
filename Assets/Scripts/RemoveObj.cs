using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveObj : MonoBehaviour
{
    public GameObject gameObj;
    private bool IsSelected = false;
    public void DelOBJ()
    {
        if (!IsSelected)
        {
            Destroy(gameObject);
        }
    }
}
