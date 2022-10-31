using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerManager : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText;

    [SerializeField, Tooltip("Tiempo en segundos")] public float generalTime;
    private int minutos, segundos;


    void Update()
    {
        generalTime -= Time.deltaTime;
        if (generalTime < 0) generalTime = 0;
        timerText.text = generalTime.ToString();
        minutos = (int)(generalTime / 60f);
        segundos = (int)(generalTime - minutos * 60f);
        timerText.text = string.Format("{0:00}:{1:00}", minutos, segundos);

        if (generalTime == 0) { 
            //Ir a escena de perder
            Destroy(this);
        }
    }
}
