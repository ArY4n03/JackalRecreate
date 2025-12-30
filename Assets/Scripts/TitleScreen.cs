using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    public void StartBtn()
    {
        SceneManager.LoadScene("Level1");
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
