using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private PlayerAwarenessController awarenessController;
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sr;
    private Enemy enemy;
    private float speed = 3.5f;
    private void Awake()
    {
        awarenessController = GetComponent<PlayerAwarenessController>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
        sr = GetComponentInChildren<SpriteRenderer>();
        enemy = GetComponent<Enemy>();
    }


    private void Update()
    {
        handleAnimation();
    }
    private void FixedUpdate()
    {
        moveTowardsPlayer();
    }
    private void moveTowardsPlayer()
    {

        if (awarenessController.isAware)
        {
            rb.linearVelocityX = awarenessController.PlayerDir.x * speed;

            bool flip = rb.linearVelocityX < 0;
            sr.flipX = flip;


        }
    }


    private void handleAnimation() => anim.SetBool("isAware", awarenessController.isAware);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Player>())
        {
            enemy.Damage(1);
        }       
    }
}

