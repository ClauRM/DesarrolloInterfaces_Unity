using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionGoalRed : MonoBehaviour
{
    public Transform balonPosicion; //posicionar balon al centro

    //debe tener condicion trigger
    private void OnTriggerEnter(Collider other)
    {
        int golesRojo = PlayerPrefs.GetInt("puntosRojos", 0); //recuperar valor de PlayerPrefs
        golesRojo++; //sumar puntos
        PlayerPrefs.SetInt("puntosRojos", golesRojo);//guardar los puntos
        Debug.Log("GooooL del equipo Rojo! Los Rojos han marcado " + golesRojo + " goles");
        ReposicionarBalon(); //llama a la funcion para reposicionar balon
        if (golesRojo >= 3)
        {
            Debug.Log("¡¡¡ GANA EL EQUIPO ROJO !!!");
            PlayerPrefs.SetInt("puntosRojos", 0);
            PlayerPrefs.SetInt("puntosAzules", 0);
        }
    }

    //punto de partida al iniciar el juego
    void Start()
    {
        balonPosicion = GameObject.FindGameObjectWithTag("soccerball").transform; // referencia del balon con etiqueta soccerball
    }

    void ReposicionarBalon()
    {
        balonPosicion.position = new Vector3(0f, 5f, 0f); //ajusta las coordenadas al centro
    }

    //se ejecuta en todo momento
    void Update()
    {

    }
}
