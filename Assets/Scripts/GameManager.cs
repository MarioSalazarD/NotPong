using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum NumeroJugador
{
    UNO, DOS
}

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI textMarcador1;
    public TextMeshProUGUI textMarcador2;
    public BallController ballController;

    private int puntajeJugador1 = 0;
    private int puntajeJugador2 = 0;
    private bool mIsRunning = true;

    private int player1Lives = 12;
    private int player2Lives = 12;


    private void Start()
    {
        // Se inscribe el GameManager al evento OnGoal
        ballController.OnGoal += BallController_OnGoal;
        textMarcador1.text = puntajeJugador1.ToString();
        textMarcador2.text = puntajeJugador2.ToString();
    }

    private void BallController_OnGoal(object sender, System.EventArgs e)
    {
        NumeroJugador numJugador = (e as OnGoalEventArg).jugador;

        if (numJugador == NumeroJugador.UNO)
        {
            puntajeJugador1++;
        }else
        {
            puntajeJugador2++;
        }

        textMarcador1.text = puntajeJugador1.ToString();
        textMarcador2.text = puntajeJugador2.ToString();

        ballController.ReInit();
        mIsRunning = false;
    }


     public void loseLives1()
    {
        player1Lives--;

        if (player1Lives <= 0)
        {
            Invoke(nameof(delay1),1.0f);
            player1Lives=12;
        }
    }

    public void loseLives2()
    {
        player2Lives--;

        if (player2Lives <= 0)
        {
            Invoke(nameof(delay2),1.0f);
            player2Lives=12;
        }
    }



    public void delay1(){
        FindObjectOfType<PaddleParent1>().resetChild();
    }

    public void delay2(){
        FindObjectOfType<PaddleParent2>().resetChild();
    }

    private void Update()
    {
        if (!mIsRunning && Input.GetKeyDown(KeyCode.Space))
        {
            ballController.ReStart();
            mIsRunning = true;
        }


    }
}
