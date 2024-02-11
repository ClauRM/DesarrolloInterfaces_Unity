using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class carrotMovement : MonoBehaviour
{
    public float speed = 3.0F; // velocidad
    public float rotateSpeed = 3.0F; // velocidad de rotación
    public float jumpForce = 8.0F; // fuerza de salto
    public float gravity = 30.0F; // gravedad

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;

    void Start()
    {
        //Get toma el componente CharacterController
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        // Rotar alrededor de horizontal
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

        // Mover hacia delante y hacia atrás
        float horizontalInput = Input.GetAxis("Vertical");
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * horizontalInput;
        controller.SimpleMove(forward * curSpeed);

        // Aplicar la gravedad
        ApplyGravity();

        // Detectar el salto
        if (controller.isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                // Aplicar fuerza de salto
                moveDirection.y = jumpForce;
            }
        }

        // Aplicar movimiento vertical
        controller.Move(moveDirection * Time.deltaTime);
    }
    void ApplyGravity()
    {
        // Aplicar la gravedad a la dirección vertical
        if (!controller.isGrounded)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }
        else
        {
            // Si está en el suelo, reiniciar la dirección vertical
            moveDirection.y = -0.5f;
        }
    }
}
