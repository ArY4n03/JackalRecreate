using UnityEngine;

public class Allly : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collision Detected");
        if (other.gameObject.GetComponent<Player>())
        {
            Debug.Log("player detected");
            rescued();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Detected");
        if(collision.gameObject.GetComponent<Player>())
        {
            Debug.Log("player detected");
            rescued();
        }
    }


    private void rescued()
    {
        GetComponentInParent<GameManager>().score += 70;
        Destroy(gameObject);
    }
}
