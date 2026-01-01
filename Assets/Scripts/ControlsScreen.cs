using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsScreen : MonoBehaviour
{
    public void GoBack()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}
