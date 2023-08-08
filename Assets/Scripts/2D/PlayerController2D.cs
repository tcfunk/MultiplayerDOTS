using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    public float movementSpeed = 10f;
    // private CharacterController _controller;
    private Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        // _controller = GetComponent<CharacterController>();
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var movementInput = Vector3.zero;
        movementInput.x = Input.GetAxis("Horizontal");
        movementInput.y = Input.GetAxis("Vertical");

        // _controller.SimpleMove(movementInput * movementSpeed);
        _rb.velocity = movementInput.normalized * movementSpeed;
    }
}
