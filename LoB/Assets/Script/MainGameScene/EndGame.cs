using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public bool? IsWin;
    [SerializeField] private Text StageText;
    [SerializeField] private GameObject FadeImage;
    [SerializeField] private Text ResultText;
    private Scene scene;
    private int nextScene;
    private Remain re;

    void Start()
    {
        IsWin = null;
        scene = SceneManager.GetActiveScene();
        int curScene = scene.buildIndex;
        nextScene = curScene + 1;
        re = FindObjectOfType<Remain>();
    }
    void Update()
    {
        JudgeEnd();
    }
    void JudgeEnd()
    {
        if (IsWin == true)
            GameWin();
        if (IsWin == false)
            GameLose();
    }
    void GameWin()
    {
        StageText.gameObject.SetActive(false);
        ResultText.text = "Win";
        Invoke("FadeOut", 2);
    }
    void GameLose()
    {
        StageText.gameObject.SetActive(false);
        ResultText.text = "Lose";
        Invoke("FadeOut", 2);
    }
    void FadeOut()
    {
        FadeImage.gameObject.SetActive(true);
        Invoke("ToNextLevel", 2);
    }
    void ToNextLevel()
    {
        if(re.IsNomal == true)
        {
            if (IsWin == true)
                SceneManager.LoadScene(nextScene);
            if (IsWin == false)
                SceneManager.LoadScene(10);
        }
        if(re.IsNomal == false)
        {
            if (IsWin == false)
                SceneManager.LoadScene(13);
        }

    }
}

