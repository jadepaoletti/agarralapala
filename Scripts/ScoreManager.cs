using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TMP_Text textPlayer1, textPlayer2;
    [Header ("Score Actual")]
    [SerializeField] public int player1;
    [SerializeField] public int player2;
    [Header("Scores")]
    [SerializeField] public int pizzaHecha;
    [SerializeField] public int pizzaBienHecha;
    [SerializeField] public int pizzaMalHecha;
    [SerializeField] public int pizzaMalCocinada;
    [SerializeField, Tooltip("Puntaje mínimo para poder ganar")] public int minScore;
    [Header("Escenas")]
    [Tooltip("Número de la escena victoria")] public int escenaVictoria;
    [Tooltip("Número de la escena derrota")] public int escenaDerrota;

    

    void Update()
    {
        if (player1 < minScore && player2 < minScore) Perder(escenaDerrota);
        
    }

    void Ganar(int escena)
    {
        SceneManager.LoadScene(escena);
    }

    void Perder(int escena)
    {
        SceneManager.LoadScene(escena);
    }
}
