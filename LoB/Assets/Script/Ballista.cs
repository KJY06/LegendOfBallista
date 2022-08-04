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
    void Start()
    {
        FireArrowcnt = 0;
        target = transform.position;
        Fire = FindObjectOfType<SpawnIcon>();
    }
    void Update()
    {
        shoot();
        Follow();
    }
    void shoot()
    {
        if(Fire.FItemGet == true)
        {
            if(Input.GetKeyDown(KeyCode.V))
            {
                FireArrowcnt = 10;
                Fire.FItemGet = false;
            }
        }
        time += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (FireArrowcnt == 0)
            {
                if (time >= 0.5f)
                {
                    time = 0;
                    Instantiate(arrowprefab, transform.position, transform.rotation);
                }
            }

            else
            {
                if (time >= 0.5f)
                {
                    FireArrowcnt -= 1;
                    time = 0;
                    Instantiate(Firearrowprefab, transform.position, transform.rotation);
                }
            }
        }
    }
    void Follow()
    {
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        angle = Mathf.Atan2(mouse.y - target.y, mouse.x - target.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
    }
}
