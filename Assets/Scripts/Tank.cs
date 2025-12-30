using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class Tank : MonoBehaviour
{
    private PlayerAwarenessController awarenessController;
    private Rigidbody2D rb;
    private float Speed = 1.5f;
    private EnemyShooter enemy_shooter;
    private float min_dist = 3.5f;
    private int life = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        awarenessController = GetComponent<PlayerAwarenessController>();
        enemy_shooter = GetComponent<EnemyShooter>();
    }

    public void damaged() => life -= 1;
    void Update()
    {
        // Calculate angle
        float angle = Mathf.Atan2(awarenessController.PlayerDir.y, awarenessController.PlayerDir.x) * Mathf.Rad2Deg - 90f;

        // Apply rotation (Z axis in 2D)
       transform.rotation = Quaternion.Euler(0f, 0f, angle);

        if (awarenessController.isAware && awarenessController.dir.magnitude > min_dist)

        {

            Debug.Log(awarenessController.dir.magnitude);
             rb.linearVelocity = awarenessController.PlayerDir * Speed;
        }
    }
}
