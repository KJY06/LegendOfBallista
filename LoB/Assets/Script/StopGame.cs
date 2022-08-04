using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopGame : MonoBehaviour
{
    [SerializeField] private GameObject Pannel;
    private bool IsStop;
    void Start()
    {
        IsStop = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            ESC();
    }

    void ESC()
    {
        if(IsStop == false)
        {
            Pannel.gameObject.SetActive(true);
            Time.timeScale = 0;
            IsStop = true;
        }
        else
        {
            Pannel.gameObject.SetActive(false);
            Time.timeScale = 1;
            IsStop = false;
        }
    }

    public void OnClickToContinue()
    {
        IsStop = true;
        ESC();
    }
    public void OnClickToExit()
    {
        SceneManager.LoadScene("Title");
    }
}
