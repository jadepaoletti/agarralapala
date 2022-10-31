using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoDeVidaAudios : MonoBehaviour
{
    public float tiempoDeVida;

    void Start()
    {
        Destroy(gameObject, tiempoDeVida);
    }

}
