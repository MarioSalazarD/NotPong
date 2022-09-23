using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moreBalls : MonoBehaviour
{
    public float Speed;



    void Update()
    {
        transform.Translate (new Vector2 (1f,0f)* Time.deltaTime*Speed);
    }


}
