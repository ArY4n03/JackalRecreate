using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource BGM;
    [SerializeField] AudioSource SFX;

    [SerializeField] private AudioClip backgroundMusic;
    private void Awake()
    {
        BGM.clip = backgroundMusic;
        BGM.Play();
    }
}
