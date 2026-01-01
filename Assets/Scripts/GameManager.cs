using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int score=0;
    public int playerLife;
    [SerializeField] private string next_level;
    private Player player;
    private void Awake()
    {
        score = ScoreManager.score;
        player = GetComponentInChildren<Player>();
    }

    private void Update()
    {
        playerLife = player.life;
    }
    public void increment_score(int value)
    {
        score += value;
    }
    
    public void load_nextScene()
    {
        ScoreManager.score = score;
        SceneManager.LoadScene(next_level);
    }
}
