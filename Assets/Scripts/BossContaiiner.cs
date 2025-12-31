using UnityEngine;
using UnityEngine.SceneManagement;

public class BossContaiiner : MonoBehaviour
{
    private GameManager gameManager;

    private void Awake()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }
    void Update()
    {
        if(transform.childCount == 0)
        {
            gameManager.load_nextScene();
        }
    }
}
