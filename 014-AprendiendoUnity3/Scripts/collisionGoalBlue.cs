using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionGoalBlue : MonoBehaviour
{
    public Transform balonPosicion; //posicionar balon al centro
    //debe tener condicion trigger
    private void OnTriggerEnter(Collider other)
    {
        int golesAzul = PlayerPrefs.GetInt("puntosAzules", 0); //recuperar valor de PlayerPrefs
        golesAzul++; //sumar puntos
        PlayerPrefs.SetInt("puntosAzules", golesAzul);//guardar los puntos
        Debug.Log("GooooL del equipo Azul! Los Azules han marcado " + golesAzul + " goles");
        ReposicionarBalon(); //llama a la funcion para reposicionar balon
        if (golesAzul >= 3)
        {
            Debug.Log("¡¡¡ GANA EL EQUIPO AZUL !!!");
            PlayerPrefs.SetInt("puntosAzules", 0);
            PlayerPrefs.SetInt("puntosRojos", 0);
        }
    }

    //punto de partida al iniciar el juego
    void Start()
    {
        balonPosicion = GameObject.FindGameObjectWithTag("soccerball").transform; // referencia del balon con etiqueta soccerball
    }
    // Reposiciona el balón en el centro del campo
    void ReposicionarBalon()
    {
        balonPosicion.position = new Vector3(0f, 5f, 0f); //ajusta las coordenadas al centro
    }
    //se ejecuta en todo momento
    void Update()
    {

    }
}
