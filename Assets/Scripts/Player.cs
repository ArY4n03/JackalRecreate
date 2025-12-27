using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour
{
    [SerializeField]private float speed = 5.5f;
    private Vector2 move_input;
    private Rigidbody2D rb;
    public int life = 5;
    public bool destroyed = false;
    private SpriteRenderer sr;

    [SerializeField] private Sprite n;
    [SerializeField] private Sprite ne;
    [SerializeField] private Sprite nw;
    [SerializeField] private Sprite s;
    [SerializeField] private Sprite se;
    [SerializeField] private Sprite sw;
    [SerializeField] private Sprite e;
    [SerializeField] private Sprite w;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if(life >= 0)
        {
            rb.linearVelocity = move_input * speed;
            update_sprites(move_input);
        }
    }

    private void update_sprites(Vector2 dir)
    {
        if(dir.x > 0 && dir.y == 0)
        {
            sr.sprite = e;
        }
        else if (dir.x < 0 && dir.y == 0)
        {
            sr.sprite = w;
        }
        else if (dir.x == 0 && dir.y > 0)
        {
            sr.sprite = n;
        }
        else if (dir.x == 0 && dir.y < 0)
        {
            sr.sprite = s;
        }
        else if (dir.x > 0 && dir.y > 0)
        {
            sr.sprite = ne;
        }
        else if (dir.x > 0 && dir.y < 0)
        {
            sr.sprite = se;
        }
        else if (dir.x < 0 && dir.y > 0)
        {
            sr.sprite = nw;
        }
        else if (dir.x < 0 && dir.y < 0)
        {
            sr.sprite = sw;
        }
        else
        {
            sr.sprite = n;
        }
    }

    private void OnMove(InputValue inputvalue)
    {
        move_input = inputvalue.Get<Vector2>();
       
    }
}
