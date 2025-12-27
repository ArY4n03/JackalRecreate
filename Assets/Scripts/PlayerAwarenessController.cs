using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerAwarenessController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public bool isAware { get; private set; }
    public Vector2 PlayerDir { get; private set; }

    [SerializeField] private float Distance;
    private Transform player;

    private void Awake()
    {
        player = FindFirstObjectByType<PlayerShoot>().transform;
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 dir = player.position - transform.position;
        PlayerDir = dir.normalized;

        

        if(dir.magnitude <= Distance)
        {
            isAware = true;
        }
        else
        {
            isAware = false;
        }
    }
}
