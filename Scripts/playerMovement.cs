using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController characterController;

    public float playerSpeed = 12f;
    public float playerGravity = -9.81f;

    // Vector3 velocity;

    // Update is called once per frame
    void Update()
    {
        float xaxis = Input.GetAxis("Horizontal");
        float zaxis = Input.GetAxis("Vertical");

        Vector3 move = transform.right * xaxis + transform.forward * zaxis;

        characterController.Move(move * playerSpeed * Time.deltaTime);

        // velocity.y += gravity;
    }
}
