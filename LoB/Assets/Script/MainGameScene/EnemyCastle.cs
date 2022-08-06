using UnityEngine;
using UnityEngine.UI;

public class EnemyCastle : MonoBehaviour
{
    public int hp;
    [SerializeField] private Text Hptext;
    [SerializeField] private Sprite[] sprite = new Sprite[4];
    private SpriteRenderer spriteRenderer;

    private CameraShake shake;
    [SerializeField] private GameObject Flag;
    private EndGame gameend;
    private Coin coin;
    private AudioSource au;

    private Castle remainHp;
    private Coin remainCoin;
    private SpawnIcon remainFitem;
    private SpawnIcon remainCitem;
    private Remain remain;

    void Start()
    {
        Hptext.text = $"Hp     :     {hp}";

        au = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        shake = FindObjectOfType<CameraShake>();
        gameend = FindObjectOfType<EndGame>();
        coin = FindObjectOfType<Coin>();
        
        remainHp = FindObjectOfType<Castle>();
        remainCoin = FindObjectOfType<Coin>();
        remainFitem = FindObjectOfType<SpawnIcon>();
        remainCitem = FindObjectOfType<SpawnIcon>();
        remain = FindObjectOfType<Remain>();
        if (remain.IsNomal == false)
        {
            Hptext.gameObject.SetActive(false);
        }
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
    void SaveState()
    {
        remain.hp = remainHp.hp;
        remain.coin = remainCoin.coin;
        remain.Fitemget = remainFitem.FItemGet;
        remain.Citemget = remainCitem.CItemGet;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(remain.IsNomal == true)
        {
            if (collision.CompareTag("Friendly"))
            {
                au.Play();
                hp -= 1;
                shake.shakeCnt = 0;
                Hptext.text = $"Hp     :     {hp}";
            }
            if (collision.CompareTag("Elite"))
            {
                au.Play();
                hp -= 2;
                shake.shakeCnt = 0;
                Hptext.text = $"Hp     :     {hp}";
            }
            if (collision.CompareTag("BossFriendly"))
            {
                au.Play();
                hp -= 7;
                shake.shakeCnt = 0;
                Hptext.text = $"Hp     :     {hp}";
            }
            if (hp <= 0)
            {
                SaveState();
                Flag.gameObject.SetActive(true);
                gameend.IsWin = true;
                Destroy(gameObject);
            }
            ChangeSprite();
        }
        if(remain.IsNomal == false)
        {
            if (collision.CompareTag("Friendly") || collision.CompareTag("Elite") || collision.CompareTag("BossFriendly"))
            {
                au.Play();
                coin.point += 20;
                coin.coin += 20;
                shake.shakeCnt = 0;
            }
        }
    }
}
