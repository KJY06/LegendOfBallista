using UnityEngine;

public class Ballista : MonoBehaviour
{
    private float angle;
    private Vector2 target, mouse;

    [SerializeField] private GameObject arrowprefab;
    [SerializeField] private GameObject Firearrowprefab;

    private float time;
    private int FireArrowcnt;
    private SpawnIcon Fire;

    [SerializeField] private GameObject fire;
    private AudioSource au;
    void Start()
    {
        FireArrowcnt = 0;
        target = transform.position;
        Fire = FindObjectOfType<SpawnIcon>();
    }
    void Update()
    {
        UseItem();
        shoot();
        Follow();
    }
    void Follow() //마우스에 따라 회전하기
    {
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition); //마우스의 포인터의 위치
        angle = Mathf.Atan2(mouse.y - target.y, mouse.x - target.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
    }
    void UseItem() //불화살 사용
    {
        if (Fire.FItemGet == true)
        {
            au = fire.GetComponent<AudioSource>();
            au.Play();
            if (Input.GetKeyDown(KeyCode.V))
            {
                FireArrowcnt = 10;
                Fire.FItemGet = false;
            }
        }
    }
    void shoot() //화살 쏘기
    {
        time += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            if (FireArrowcnt == 0)
            {
                if (time >= 0.4f)
                {
                    au = GetComponent<AudioSource>();
                    au.Play();
                    time = 0;
                    Instantiate(arrowprefab, transform.position, transform.rotation);
                }
            }
            else
            {
                if (time >= 0.4f)
                {
                    au = fire.GetComponent<AudioSource>();
                    au.Play();
                    time = 0;
                    FireArrowcnt -= 1;
                    Instantiate(Firearrowprefab, transform.position, transform.rotation);
                }
            }
        }
    }

}
