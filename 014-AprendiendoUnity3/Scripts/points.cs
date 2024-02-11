using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntos : MonoBehaviour
{
    int puntosAzules;
    int puntosRojos;
    //punto de partida al iniciar el juego
    void Start()
    {
        puntosAzules = 0; //al empezar el juego
        puntosRojos = 0;
        PlayerPrefs.SetInt("puntosAzules", puntosAzules);//PlayerPrefs para guardar la puntuacion
        PlayerPrefs.SetInt("puntosRojos", puntosRojos);
    }

    //se ejecuta en todo momento
    void Update()
    {

    }
}
