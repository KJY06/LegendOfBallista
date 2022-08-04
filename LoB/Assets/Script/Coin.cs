using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public int point;
    public int pointcnt;
    public int coin;
    [SerializeField] private Text Cointext;
    private SpawnIcon PlusCoin;

    void Start()
    {
        PlusCoin = FindObjectOfType<SpawnIcon>();
        Cointext.text = "Coin :     0";
        point = 0;
        pointcnt = 0;
        coin = 0;
    }
    private void Update()
    {
        Interaction();
        UseItem();
    }

    void Interaction()
    {
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
                PlusCoin.CItemGet = false;
                coin += 100;
            }
        }
    }

}
