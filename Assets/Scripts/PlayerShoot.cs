using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerShoot : MonoBehaviour
{
    [SerializeField]private GameObject bullet_prefab;
    [SerializeField] private GameObject grenade_prefab;
    private float bulletSpeed = 3.5f;
    private bool can_fire = false;
    private float shootCooldown = 0.5f;
    private float lastFireTime = 0f;
    private float lastGrenadeTime = 0f;
    private bool can_throw = false;
    private float throwCooldown = 1f;
    private Player player;
    private void Awake()
    {
        player = GetComponent<Player>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(can_fire && player.life >=0)
        {
            float timeSinceFire = Time.time - lastFireTime;

            if(timeSinceFire >= shootCooldown)
            {
                shoot(bullet_prefab,Vector3.up);
                lastFireTime = Time.time;
            }
            
        }

        if (can_throw && player.life >=0)
        {
            float timeSinceLastThrow = Time.time - lastGrenadeTime;
            if(timeSinceLastThrow >= throwCooldown)
            {
                shoot(grenade_prefab, player.move_input);
                lastGrenadeTime = Time.time;
            }
        }
    }

    private void shoot(GameObject prefab,Vector3 dir)
    {
        GameObject obj = Instantiate(prefab, transform.position, transform.rotation);
        Rigidbody2D obj_rb = obj.GetComponent<Rigidbody2D>();

        obj_rb.linearVelocity = bulletSpeed * dir;
    }

    private void OnAttack(InputValue inpuvalue) => can_fire = inpuvalue.isPressed;
    

    private void OnGrenade(InputValue inputvalue) => can_throw = inputvalue.isPressed;

    private void OnPause(InputValue inputvalue)
    {
       
        if (Time.timeScale == 1)
            Time.timeScale = 0;
        else
        {
            Time.timeScale = 1;
        }
            
    }
}
