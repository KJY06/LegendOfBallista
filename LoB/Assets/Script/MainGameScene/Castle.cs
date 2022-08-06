using UnityEngine;
using UnityEngine.UI;

public class Castle : MonoBehaviour
{
    public int hp;
    public bool IsExist;
    [SerializeField] private Text Hp;
    [SerializeField] private Sprite[] sprite = new Sprite[4];
    [SerializeField] private GameObject Flag;
    private SpriteRenderer spriteRenderer;
    private CameraShake shake;
    private EndGame gameend;
    private Remain re;
    private Coin c;
    private EndlessPoint end;
    private AudioSource au;

    private void Awake()
    {
        au = GetComponent<AudioSource>();
        end = FindObjectOfType<EndlessPoint>();
        re = FindObjectOfType<Remain>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        shake = FindObjectOfType<CameraShake>();
        gameend = FindObjectOfType<EndGame>();
        c = FindObjectOfType<Coin>();
    }
    void Start()
    {
        hp = re.hp;
        Hp.text = $"Hp     :     {hp}";
        IsExist = true;
    }
    void ChangeSprite()
    {
        if (hp > 3)
        {
            spriteRenderer.sprite = sprite[0];
        }
        if (hp == 3)
        {
            spriteRenderer.sprite = sprite[1];
        }
        if (hp == 2)
        {
            spriteRenderer.sprite = sprite[2];
        }
        if (hp <= 1)
        {
            spriteRenderer.sprite = sprite[3];
        }
    }
    void SavePoint()
    {
        end.point = c.point;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            au.Play();
            hp -= 1;
            Hp.text = $"Hp     :     {hp}";
            shake.shakeCnt = 0;
        }
        if (collision.CompareTag("EliteEnemy"))
        {
            au.Play();
            hp -= 2;
            Hp.text = $"Hp     :     {hp}";
            shake.shakeCnt = 0;
        }
        if (collision.CompareTag("Boss"))
        {
            au.Play();
            hp -= 7;
            Hp.text = $"Hp     :     {hp}";
            shake.shakeCnt = 0;
        }
        if (hp <= 0)
        {
            if (re.IsNomal == false)
                SavePoint();
            Flag.gameObject.SetActive(true);
            gameend.IsWin = false;
            IsExist = false;
            Destroy(gameObject);
        }
        ChangeSprite();
    }
}
