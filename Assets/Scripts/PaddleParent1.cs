using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleParent1 : MonoBehaviour
{
    public void resetChild()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit" + other.name);
    }
}
