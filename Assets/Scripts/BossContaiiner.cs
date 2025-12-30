using UnityEngine;
using UnityEngine.SceneManagement;

public class BossContaiiner : MonoBehaviour
{
    void Update()
    {
        if(transform.childCount == 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
