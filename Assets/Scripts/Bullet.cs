using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float spawntime;
    private float cooldown = 3.5f;
    public bool isPlayerBullet = true;
    private void Awake()
    {
        spawntime = Time.time;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float cur_time = Time.time;

        if(cur_time - spawntime > cooldown)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(isPlayerBullet)
        {
            
            if (collision.GetComponent<Enemy>())
            {
               
                collision.GetComponent<Enemy>().OnHit();
            }
        }
    }
}
