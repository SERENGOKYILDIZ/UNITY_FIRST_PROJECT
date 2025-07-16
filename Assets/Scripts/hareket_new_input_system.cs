﻿using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class hareket_new_input_system : MonoBehaviour
{
    public Rigidbody2D rb;

    public float moveSpeed;

    private Vector2 _moveDirection;

    public InputActionReference move;
    public InputActionReference fire;

    void Start()
    {

    }

    void Update()
    {
        _moveDirection = move.action.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(_moveDirection.x * moveSpeed, _moveDirection.y * moveSpeed);
    }

    private void OnEnable()
    {
        fire.action.started += Fire;
    }
    private void OnDisable()
    {
        fire.action.started -= Fire;
    }

    private void Fire(InputAction.CallbackContext context)
    {
        Debug.Log("Ateş tuşuna basındı!");
    }
}
