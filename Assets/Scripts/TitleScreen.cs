using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    public void StartBtn()
    {
        SceneManager.LoadScene("StartingScreen");
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
