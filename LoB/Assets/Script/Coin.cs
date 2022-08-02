using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public int point;
    public int pointcnt;
    public int coin;
    [SerializeField] private Text Cointext;

    void Start()
    {

        Cointext.text = "Coin : 0";
        point = 0;
        pointcnt = 0;
        coin = 0;
    }
    private void Update()
    {
        
        Cointext.text = $"Coin : {coin}";
        if (point % 100 == 0 && point != 0 && pointcnt == 0)
        {
            Generate spon = FindObjectOfType<Generate>();
            spon.forspon = true;
            spon.bosscnt = 0;
            pointcnt++;

        }
    }

}
