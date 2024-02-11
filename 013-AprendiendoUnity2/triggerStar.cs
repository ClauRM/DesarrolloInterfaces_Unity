using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerStar : MonoBehaviour
{
    // Este metodo se llama cuando otro collider entra en el trigger de la estrella
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("+1 punto");
        // Cuando hay colision con otro objeto
        Destroy(gameObject); //este desaparece
    }
}
