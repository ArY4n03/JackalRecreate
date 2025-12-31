using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]public int life;
    [SerializeField] private int scoreValue;
    private GameManager gameManager;
    public bool isTank;
    public bool isActive = true;

    private void Awake()
    {
        gameManager = FindAnyObjectByType<GameManager>();

    }
    public void Damage()
    {
        life -= 1;

        if (life == 0)
        {
            isActive = false;
            gameManager.increment_score(scoreValue);
            if (!isTank)
                Destroy(gameObject);
        }
       
    }


}
