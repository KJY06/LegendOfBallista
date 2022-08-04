using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public bool? IsWin;
    [SerializeField] private GameObject StageText;
    [SerializeField] private GameObject FadeImage;
    [SerializeField] private Text ResultText;

    void Start()
    {
        IsWin = null;
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
        Invoke("FadeOut", 6);
    }
    void GameLose()
    {
        StageText.gameObject.SetActive(false);
        ResultText.text = "Lose";
        Invoke("FadeOut", 6);
    }
    void FadeOut()
    {
        FadeImage.gameObject.SetActive(true);
        Invoke("ToNextLevel", 3);
    }
    void ToNextLevel()
    {
        if(IsWin == true)
        {

        }
        if (IsWin == false)
        {

        }
    }
}

