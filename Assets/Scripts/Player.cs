using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour
{
    [SerializeField]private float speed = 5.5f;
    private Vector2 move_input;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.linearVelocity = move_input * speed;
    }

    private void OnMove(InputValue inputvalue)
    {
        move_input = inputvalue.Get<Vector2>();
       
    }
}
