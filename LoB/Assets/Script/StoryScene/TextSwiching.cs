using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextSwiching : MonoBehaviour
{
    [SerializeField] private Text TextBox;
    [SerializeField] private GameObject FadeOut;
    private int textnumber;
    void Start()
    {
        FadeOut.gameObject.SetActive(false);
        textnumber = -1;
    }
    void Update()
    {
        Switching();
    }

    void Switching()
    {
        if (Input.anyKeyDown)
            textnumber++;
        switch(textnumber)
        {
            case 0:
                TextBox.text = "수세기 전...";
                break;
            case 1:
                TextBox.text = "비옥하기로 유명한 땅. \"진도(眞島)\"에 6부족이 정착했다.";
                break;
            case 2:
                TextBox.text = "6부족은 서로를 도와가며 점차 그 크기를 넓혀갔고\n오랫동안 평화롭게 지내왔다.";
                break;
            case 3:
                TextBox.text = "서로 도와 번성한 부족들은 훗날 각자의 왕국들을 이루었다.";
                break;
            case 4:
                TextBox.text = "하지만...";
                break;
            case 5:
                TextBox.text = "도움과 평화는 그저 옛말에 그치게 되었다.";
                break;
            case 6:
                TextBox.text = "현재.";
                break;
            case 7:
                TextBox.text = "자립한 6왕국은 세력을 넓히려 서로 점령하고\n전쟁을 치르는 중이다...";
                break;
            case 8:
                TextBox.text = "왕국을 이끄는 너는 과연 살아남을 수 있을까?";
                break;
        }
        if(textnumber > 8)
        {
            FadeOut.gameObject.SetActive(true);
            Invoke("GameStart", 2);
        }
    }
    void GameStart()
    {
        SceneManager.LoadScene(4);
    }
}
