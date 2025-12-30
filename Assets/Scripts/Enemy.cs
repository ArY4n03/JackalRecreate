using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]private int life;

    
  
    public void Damage()
    {
        life -= 1;

        if(life == 0)
            Destroy(gameObject);
    }
}
