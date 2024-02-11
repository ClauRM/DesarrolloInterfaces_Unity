using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPlayer : MonoBehaviour
{
    //declaracion de variables
    public Transform objetoDestino; //tipo Transform
    public float desfaseHorizontal = 0.0f;
    private Camera myCamera;
    // Start al inciar
    private void Start()
    {
        myCamera = GetComponent<Camera>(); //funcion
    }

    // Update en cada momento
    private void Update()
    {
        if (objetoDestino != null)
        {
            Vector3 positionCamera = myCamera.transform.position; //posicion de la camara
            positionCamera.x = objetoDestino.position.x + desfaseHorizontal; //moverlo en el eje x
            myCamera.transform.position = positionCamera; //seteo la posicion actual
        }
        
    }
}