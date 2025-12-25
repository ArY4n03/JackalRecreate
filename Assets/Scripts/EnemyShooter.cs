using UnityEngine;

public class EnemyShooter : MonoBehaviour
{

    private float bullet_speed = 2.2f;
    private float cooldown = 1.5f;
    private float lastShootTime;
    private Rigidbody2D rb;
    private PlayerAwarenessController awarenessController;
    private Vector2 targetDir;
    [SerializeField] private GameObject bulletPrefab;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        awarenessController = GetComponent<PlayerAwarenessController>();

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        updateDirection();

        float timeSinceLastShoot = Time.time - lastShootTime;

        if (timeSinceLastShoot >= cooldown)
        {
            shootPlayer();
            lastShootTime = Time.time;
        }


    }

    private void updateDirection()
    {
        if (awarenessController.isAware)
        {
            targetDir = awarenessController.PlayerDir;
        }
        else
        {
            targetDir = Vector2.zero;
        }

    }

    private void shootPlayer()
    {
        if (awarenessController.isAware)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            Rigidbody2D bullet_rb = bullet.GetComponent<Rigidbody2D>();
            bullet.GetComponent<Bullet>().isPlayerBullet = false;
            bullet_rb.linearVelocity = bullet_speed * targetDir;
        }
    }
}
