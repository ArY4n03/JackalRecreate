using UnityEngine;
using UnityEngine.InputSystem;
public class General : MonoBehaviour
{


    private void OnPause(InputValue inputValue)
    {
        if (inputValue.isPressed)
        {
            Debug.Log("hello paused");
            if (Time.timeScale == 0)
                Time.timeScale = 1;
            else
                Time.timeScale = 0;
        }
    }
    private void destroy()
    {

        
    }
}
