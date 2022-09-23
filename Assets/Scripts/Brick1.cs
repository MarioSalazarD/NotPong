using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick1 : MonoBehaviour
{
    private  void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Ball"))
        {
            gameObject.SetActive(false);

            FindObjectOfType<GameManager>().loseLives1();

        }
    }
}
