using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = Getcomponent<Rigidbody>();  
    }

    void onMove(InputValue movementValue)
    {
        // Function body (instruction for computer to see.
        Vector2 movementVector = movementValue.Get<Vector2>();
    }

    void fixedUpdate()
    {

    }
}
