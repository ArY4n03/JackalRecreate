using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingScreen : MonoBehaviour
{
    public void nextScene()
    {
        SceneManager.LoadScene("Level1");
    }
}
