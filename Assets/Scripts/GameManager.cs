using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int score=0;
    public int playerLife;

    public void increment_score(int value)
    {
        score += value;
    }
}
