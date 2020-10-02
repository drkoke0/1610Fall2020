using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public CharacterController controller;
    public float moveSpeed = 3f, gravity = -9.81f, jumpForce = 30f;
        
    private Vector3 moveDirection,;
    private float yDirection;
    private void Update()
    {
        var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");
        yDirection += gravity * Time.deltaTime;
        if (controller.isGrounded)
        {
            yDirection = -1f;
        }
        moveDirection.Set(newX: moveSpeedInput, newY: yDirection, newZ: 0);
        
        if (Input.GetButtonDown("Jump");
        {
            moveDirection.y += jumpForce;
        }
        
        var movement = moveDirection * Time.deltaTime;
        controller.Move(movement);
    }
}
