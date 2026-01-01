using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class Tank : MonoBehaviour
{
    private PlayerAwarenessController awarenessController;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private float Speed = 1.5f;
    private EnemyShooter enemy_shooter;

    private float min_dist = 3.5f;
    private Enemy enemy;
    public bool isBoss;
    [SerializeField] private Sprite bossSprite;
    [SerializeField] private Sprite normalSprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        awarenessController = GetComponent<PlayerAwarenessController>();
        enemy_shooter = GetComponent<EnemyShooter>();
        enemy = GetComponent<Enemy>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        GetComponent<Animator>().enabled = false;

        if (isBoss)
        {
            Debug.Log("Boss Tank spawned");
            sr.sprite = bossSprite;
            enemy.life = 8;
            
        }
        else
        {
            enemy.life = 5;
            sr.sprite = normalSprite;
        }

    }

    void Update()
    {
        handleMovement();
        handleAnimation();

    }

    private void handleMovement()
    {
 

        if (awarenessController.isAware && awarenessController.dir.magnitude > min_dist && enemy.isActive)

        {
            handleRotation();
            rb.linearVelocity = awarenessController.PlayerDir * Speed;
        }
        else
        {
            
            rb.linearVelocity = Vector2.zero;
        }
    }

    private void handleRotation()
    {
        float angle = Mathf.Atan2(awarenessController.PlayerDir.y, awarenessController.PlayerDir.x) * Mathf.Rad2Deg - 90f;


        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }

    private void handleAnimation()
    {
        if (!enemy.isActive)
        {
            GetComponent<Animator>().enabled = true;
        }
    }
    private void destroyed() => Destroy(gameObject);
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<Player>())
        {
            enemy.life = -1;
            enemy.isActive = false;
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            collision.gameObject.GetComponent<Player>().OnHit();
        }
    }
}
