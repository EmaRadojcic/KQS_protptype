using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddObj : MonoBehaviour
{
    public Transform Floor;
    public void addBox()
        {
            Instantiate(Floor, new Vector3(1,0.2f,0), Quaternion.identity);
        }
}
