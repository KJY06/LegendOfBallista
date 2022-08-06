using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public int point;
    public int pointcnt;
    public int coin;
    [SerializeField] private Text Pointtext;
    [SerializeField] private Text Cointext;
    private SpawnIcon PlusCoin;
    private Remain re;

    private AudioSource au;

    private void Awake()
    {
        au = GetComponent<AudioSource>();
        PlusCoin = FindObjectOfType<SpawnIcon>();
        re = FindObjectOfType<Remain>();
    }
    void Start()
    {
        coin = re.coin;
        point = 0;
        pointcnt = 0;
    }
    private void Update()
    {
        Interaction();
        UseItem();
    }
    void Interaction()
    {
        if (re.IsNomal == false)
        {
            Pointtext.gameObject.SetActive(true);
            Pointtext.text = $"point  :  {point}";
        }
        Cointext.text = $"Coin :     {coin}";
        if (point % 100 == 0 && point != 0 && pointcnt == 0)
        {
            Generate spon = FindObjectOfType<Generate>();
            spon.forspon = true;
            spon.bosscnt = 0;
            pointcnt++;
        }
    }
    void UseItem()
    {
        if(PlusCoin.CItemGet == true)
        {
            if(Input.GetKeyDown(KeyCode.B))
            {
                au.Play();
                PlusCoin.CItemGet = false;
                coin += 100;
            }
        }
    }
}
