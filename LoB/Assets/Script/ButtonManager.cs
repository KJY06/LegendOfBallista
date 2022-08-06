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
        SceneManager.LoadScene(0);
    }
    public void OnClickToGameModeSelect()
    {
        SceneManager.LoadScene(1);
    }
    public void OnClickToTutorial()
    {
        SceneManager.LoadScene(2);
    }
    public void OnClickToNomalMode()
    {
        re.IsNomal = true;
        SceneManager.LoadScene(3);
    }
    public void OnClickToELRule()
    {
        re.IsNomal = false;
        SceneManager.LoadScene(11);
    }
    public void OnClickToEndlessMode()
    {
        re.IsNomal = false;
        SceneManager.LoadScene(12);
    }
    public void OnClickToExitGame()
    {
        Application.Quit();
    }
}
