using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMusic : MonoBehaviour
{
    [SerializeField] private GameObject BackgroundMusic;
    AudioSource backmusic;

    void Awake()
    {
        backmusic = BackgroundMusic.GetComponent<AudioSource>();
        if (backmusic.isPlaying) return;
        else
        {
            backmusic.Play();
            DontDestroyOnLoad(BackgroundMusic);
        }
    }
}
