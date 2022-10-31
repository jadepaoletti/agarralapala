using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OvenTimerManager : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText;
    public GameObject pizzaReadySound;

    [Header("Configuración")]

    [SerializeField, Tooltip("Tecla activadora")] private KeyCode tecla;
    [SerializeField, Tooltip("Tiempo en segundos")] private float ovenTime;
    [SerializeField, Tooltip("Acá va el mismo número que arriba")] private float maxOvenTime;

    private bool isTeclaActiva = false;
    private int minutos, segundos;
    private bool sono = false;

    void Update()
    {
        //Timer se activa cuando se mantienen presionadas las teclas
        if (Input.GetKeyDown(tecla))
        {
            isTeclaActiva = true;
            print("TeclaAciva:" + tecla);
        }
        if (Input.GetKeyUp(tecla))
        {
            ovenTime = maxOvenTime;
            isTeclaActiva = false;
            print("TeclaInaciva:" + tecla);
        }

        //Timer
        if (isTeclaActiva) ovenTime -= Time.deltaTime;
        if (ovenTime < 0) ovenTime = maxOvenTime;

        //Audio timer
        if (timerText.text == "3" && !sono) 
        { 
            print("Quedan 3 segundos");
            Instantiate(pizzaReadySound);
            sono = true;
        } 
        if (timerText.text == "" + maxOvenTime && sono)
        {
            sono = false;
        }
        
        //Texto timer
        timerText.text = ovenTime.ToString();
        minutos = (int)(ovenTime / 60f);
        segundos = (int)(ovenTime - minutos * 60f);
        timerText.text = string.Format("{0:0}", segundos);

        
    }
}
