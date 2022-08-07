using Random = UnityEngine.Random;
using UnityEngine;

public class SpawnIcon : MonoBehaviour
{
    private Coin buy;
    [SerializeField] private GameObject Icon1;
    [SerializeField] private GameObject Icon2;
    [SerializeField] private GameObject Icon3;
    [SerializeField] private GameObject Icon4;
    [SerializeField] private GameObject Icon5;
    [SerializeField] private GameObject FlagPack;

    private Remain re;

    public bool FItemGet;
    public bool CItemGet;
    [SerializeField] private GameObject LevelUp;
    public bool Upgrade;
    private void Awake()
    {
        buy = FindObjectOfType<Coin>();
        re = FindObjectOfType<Remain>();
        FItemGet = re.Fitemget;
        CItemGet = re.Citemget;
    }

    void Start()
    {
        Gift();
        if (re.IsNomal == false)
        {
            FlagPack.gameObject.SetActive(false);
            InvokeRepeating("Gift", 20, 20);
        }

    }
    void Gift()
    {
        int GiveItem = Random.Range(1, 3);
        if (GiveItem == 1)
        {
            FItemGet = true;
        }
        if (GiveItem == 2)
        {
            CItemGet = true;
        }
    }
    void Update()
    {
        IsPossible();
    }
    void IsPossible()
    {
        if (buy.coin >= 15)
            Icon1.gameObject.SetActive(true);
        else
            Icon1.gameObject.SetActive(false);

        if (buy.coin >= 35)
            Icon2.gameObject.SetActive(true);
        else
            Icon2.gameObject.SetActive(false);

        if (buy.coin >= 85)
            Icon3.gameObject.SetActive(true);
        else
            Icon3.gameObject.SetActive(false);

        if(FItemGet == true)
            Icon4.gameObject.SetActive(true);
        else
            Icon4.gameObject.SetActive(false);

        if (CItemGet == true)
            Icon5.gameObject.SetActive(true);
        else
            Icon5.gameObject.SetActive(false);
        Upgradeb();
    }
    void Upgradeb()
    {
        if(re.BallistaLevel == 0)
        {
            if (buy.coin >= 15)
            {
                LevelUp.gameObject.SetActive(true);
            }

            else
                LevelUp.gameObject.SetActive(false);
        }
        if (re.BallistaLevel == 1)
        {
            if (buy.coin >= 20)
                LevelUp.gameObject.SetActive(true);
            else
                LevelUp.gameObject.SetActive(false);
        }
        if (re.BallistaLevel == 2)
        {
            if (buy.coin >= 30)
                LevelUp.gameObject.SetActive(true);
            else
                LevelUp.gameObject.SetActive(false);
        }
        if (re.BallistaLevel == 3)
        {
            if (buy.coin >= 45)
                LevelUp.gameObject.SetActive(true);
            else
                LevelUp.gameObject.SetActive(false);
        }
        if (re.BallistaLevel == 4)
        {
            if (buy.coin >= 60)
                LevelUp.gameObject.SetActive(true);
            else
                LevelUp.gameObject.SetActive(false);
        }
        if(re.BallistaLevel == 5)
        {
            LevelUp.gameObject.SetActive(false);
        }
    }
}
