using UnityEngine;

public class StopBM : MonoBehaviour
{
    GameObject BackgroundMusic;
    AudioSource backmusic;
    private void Start()
    {
        BackgroundMusic = GameObject.Find("BackgroundMusic");
        backmusic = BackgroundMusic.GetComponent<AudioSource>();
        if (backmusic.isPlaying)
            Destroy(BackgroundMusic);
    }
}
