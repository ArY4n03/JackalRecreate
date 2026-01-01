using System.Runtime.CompilerServices;
using UnityEngine;

public class grenade : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    private bool isBlasting = false;
    private void Awake()
    {

        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void blast()
    {
        isBlasting = true;
        //rb.constraints = RigidbodyConstraints2D.FreezeAll;
        anim.SetBool("blast", true);
    }

    private void destroyed()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<Enemy>())
        {
            if (isBlasting)
            {
                
                blast();
            }
                
            collision.gameObject.GetComponent<Enemy>().Damage(5);
        }
    }

}
