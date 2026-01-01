using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource BGM;
    [SerializeField] public AudioSource SFX;

    [SerializeField] private AudioClip backgroundMusic;
    [SerializeField] public AudioClip explosionSound;
    [SerializeField] public AudioClip shootSound;
    private void Awake()
    {
        BGM.clip = backgroundMusic;
        BGM.Play();
    }

    public void playSFX(AudioClip clip)
    {
        SFX.clip = clip;
        SFX.Play();
    }

}
