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
                TextBox.text = "������ ��...";
                break;
            case 1:
                TextBox.text = "����ϱ�� ������ ��. \"����(����)\"�� 6������ �����ߴ�.";
                break;
            case 2:
                TextBox.text = "6������ ���θ� ���Ͱ��� ���� �� ũ�⸦ ��������\n�������� ��ȭ�Ӱ� �����Դ�.";
                break;
            case 3:
                TextBox.text = "���� ���� ������ �������� �ʳ� ������ �ձ����� �̷����.";
                break;
            case 4:
                TextBox.text = "������...";
                break;
            case 5:
                TextBox.text = "����� ��ȭ�� ���� ������ ��ġ�� �Ǿ���.";
                break;
            case 6:
                TextBox.text = "����.";
                break;
            case 7:
                TextBox.text = "�ڸ��� 6�ձ��� ������ ������ ���� �����ϰ�\n������ ġ���� ���̴�...";
                break;
            case 8:
                TextBox.text = "�ձ��� �̲��� �ʴ� ���� ��Ƴ��� �� ������?";
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
