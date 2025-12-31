using System.Runtime.CompilerServices;
using UnityEngine;

public class grenade : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {

        anim = GetComponent<Animator>();
    }
    private void blast()
    {
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
            collision.gameObject.GetComponent<Enemy>().Damage(5);
        }
    }

}
