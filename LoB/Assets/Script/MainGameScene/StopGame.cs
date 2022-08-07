using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopGame : MonoBehaviour
{
    [SerializeField] private GameObject Pannel;
    private bool IsStop;
    private AudioSource au;
    void Start()
    {
        au = GetComponent<AudioSource>();
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
        au.Play();
        IsStop = true;
        ESC();
    }
}
