using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerShoot : MonoBehaviour
{
    [SerializeField]private GameObject bullet_prefab;
    private float bulletSpeed = 3.5f;
    private bool can_fire = false;
    private float shootCooldown = 0.5f;
    private float lastFireTime = 0f;

    private void Awake()
    {
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(can_fire)
        {
            float timeSinceFire = Time.time - lastFireTime;

            if(timeSinceFire >= shootCooldown)
            {
                shoot();
                lastFireTime = Time.time;
            }
            
        }
    }

    private void shoot()
    {
        GameObject bullet = Instantiate(bullet_prefab, transform.position, transform.rotation);
        Rigidbody2D bullet_rb = bullet.GetComponent<Rigidbody2D>();

        bullet_rb.linearVelocity = bulletSpeed * Vector3.up;
    }

    private void OnAttack(InputValue inpuvalue)
    {
        can_fire = inpuvalue.isPressed;
    }
}
