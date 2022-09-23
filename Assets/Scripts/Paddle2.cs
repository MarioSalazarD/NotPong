using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2 : MonoBehaviour
{
    IA _playeria;
    PaddleController _human;

    // Start is called before the first frame update
    void Start()
    {
        _playeria = gameObject.GetComponent<IA>();
        _human = gameObject.GetComponent<PaddleController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            _playeria.enabled = !_playeria.enabled;
            _human.enabled = !_human.enabled;
        }
    }
}
