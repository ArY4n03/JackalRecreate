using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int score=0;
    public int playerLife;
    [SerializeField] private string next_level;

    public void increment_score(int value)
    {
        score += value;
    }

    public void load_nextScene()
    {
        SceneManager.LoadScene(next_level);
    }
}
