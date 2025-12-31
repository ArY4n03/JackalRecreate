using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void onContinue()
    {
        SceneManager.LoadScene("TitleScreen");
    }
    public void exitBtn()
    {
#if (UNITY_EDITOR)
        {
            UnityEditor.EditorApplication.isPlaying = false;
#endif
            Application.Quit();
        }
    }
}