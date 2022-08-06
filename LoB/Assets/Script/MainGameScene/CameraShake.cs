using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public Camera mainCamera;
    Vector3 cameraPos;

    [SerializeField] [Range(0.01f, 0.01f)] float shakeRange = 0.05f;
    [SerializeField] [Range(0.01f, 0.01f)] float duration = 0.5f;

    public int shakeCnt;
    private void Start()
    {
        shakeCnt = 1;
    }

    private void Update()
    {
        if (shakeCnt == 0)
        {
            Shake();
            shakeCnt++;
        }
    }
    public void Shake()
    {
        cameraPos = mainCamera.transform.position;
        InvokeRepeating("StartShake", 0f, 0.005f);
        Invoke("StopShake", duration);
    }

    void StartShake()
    {
        float cameraPosX = Random.value * shakeRange * 2 - shakeRange;
        float cameraPosY = Random.value * shakeRange * 2 - shakeRange;
        Vector3 cameraPos = mainCamera.transform.position;
        cameraPos.x += cameraPosX;
        cameraPos.y += cameraPosY;
        mainCamera.transform.position = cameraPos;
    }

    void StopShake()
    {
        CancelInvoke("StartShake");
        mainCamera.transform.position = new Vector3(0, 0, -10);
    }
}

