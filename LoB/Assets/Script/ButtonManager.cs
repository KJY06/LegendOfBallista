using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    private Remain re;
    AudioSource au;

    private void Start()
    {
        au = GetComponent<AudioSource>();
        re = FindObjectOfType<Remain>();
    }
    public void OnClickToTitle()
    {
        au.Play();
        Invoke("OnClickToTitle2", 0.2f);
    }
    void OnClickToTitle2()
    {
        SceneManager.LoadScene(0);
    }
    public void OnClickToGameModeSelect()
    {
        Time.timeScale = 1;
        au.Play();
        Invoke("OnClickToGameModeSelect2", 0.2f);
    }
    void OnClickToGameModeSelect2()
    {
        SceneManager.LoadScene(1);
    }
    public void OnClickToTutorial()
    {
        au.Play();
        Invoke("OnClickToTutorial2", 0.2f);
    }
    void OnClickToTutorial2()
    {
        SceneManager.LoadScene(2);
    }
    public void OnClickToNomalMode()
    {
        re.IsNomal = true;
        au.Play();
        Invoke("OnClickToNomalMode2", 0.2f);
    }
    void OnClickToNomalMode2()
    {
        SceneManager.LoadScene(3);
    }
    public void OnClickToELRule()
    {
        re.IsNomal = false;
        au.Play();
        Invoke("OnClickToELRule2", 0.2f);
    }
    void OnClickToELRule2()
    {
        SceneManager.LoadScene(11);
    }
    public void OnClickToEndlessMode()
    {
        au.Play();
        Invoke("OnClickToEndlessMode2", 0.2f);
    }
    void OnClickToEndlessMode2()
    {
        SceneManager.LoadScene(12);
    }
    public void OnClickToExitGame()
    {
        au.Play();
        Invoke("OnClickToExitGame2", 0.2f);
    }
    void OnClickToExitGame2()
    {
        Application.Quit();
    }
}
