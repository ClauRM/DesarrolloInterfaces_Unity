using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBall : MonoBehaviour
{

    //variables globales
    public float velocidadLineal = 5f;
    public float velocidadAngular = 2f;
    public float fuerzaSalto = 5f;
    public Rigidbody balon;
    //public LayerMask superficieSuelo;

    //punto de partida al iniciar el juego
    void Start()
    {
        balon = GetComponent<Rigidbody>();//el objeto debe tener un componente previo Rigidbody
        //balon.freezeRotation = true; //congelar rotacion
    }

    //se ejecuta en todo momento
    void Update()
    {
        float entradaHorizontal = Input.GetAxis("Horizontal");//tomar el input del usuario Axis
        float entradaVertical = Input.GetAxis("Vertical");

        //calcular vectores de 3 dimesiones con tipo de dato Vector3
        Vector3 direccionMovimiento = new Vector3(entradaVertical, 0f, entradaHorizontal); //calculamos la posicion en z, y, x
        Vector3 rotacionMovimiento = Vector3.Cross(transform.forward, direccionMovimiento); //aplicamos rotacion

        //Raycast para verificar si está en el suelo
        //bool enSuelo = Physics.Raycast(transform.position, Vector3.down, 0.1f, superficieSuelo);//rayo en una direccion, si es ok hay colision

        //si esta en el suelo y se presiona saltar
        if (Input.GetButtonDown("Jump"))
        {
            balon.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse); //aplicamos fuerza de salto y damos impulso
        }

        balon.AddTorque(rotacionMovimiento * velocidadAngular* balon.velocity.magnitude); //aniadimos una fuerza de torque rotacion*velocidad
        balon.AddForce(direccionMovimiento * velocidadLineal); //aniadimos una fueza lineal
    }
}
