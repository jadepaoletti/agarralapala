using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EmpezarJuego : MonoBehaviour
{
    [SerializeField] private TMP_Text player1, player2;

    [SerializeField] private bool isPlayerOneReady = false;
    [SerializeField] private bool isPlayerTwoReady = false;

    [SerializeField, Tooltip("Texto de estado del jugador")] private string readyText, notReadyText;
    [Tooltip ("Número de la escena")] public int juego;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) isPlayerOneReady = true;
        if (Input.GetKeyUp(KeyCode.LeftArrow)) isPlayerOneReady = false;
        if (Input.GetKeyDown(KeyCode.RightArrow)) isPlayerTwoReady = true;
        if (Input.GetKeyUp(KeyCode.RightArrow)) isPlayerTwoReady = false;

        if (isPlayerOneReady && isPlayerTwoReady) Empezar(juego);

        if (isPlayerOneReady) player1.text = readyText;
        else player1.text = notReadyText;
        if (isPlayerTwoReady) player2.text = readyText;
        else player2.text = notReadyText;
    }
    public void Empezar(int escenaJuego)
    {
        SceneManager.LoadScene(escenaJuego);
    }
}
