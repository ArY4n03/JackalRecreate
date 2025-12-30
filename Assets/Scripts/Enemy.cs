using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]public int life;
    [SerializeField] private int scoreValue;
    public bool isTank;
    public bool isActive = true;
    public void Damage()
    {
        life -= 1;

        if (life == 0)
        {
            isActive = false;
            if (!isTank)
                Destroy(gameObject);
        }
       
    }


}
