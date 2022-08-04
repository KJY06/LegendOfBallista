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

    public bool FItemGet;
    public bool CItemGet;
    private void Awake()
    {
        buy = FindObjectOfType<Coin>();
        FItemGet = false;
        CItemGet = false;
    }

    void Start()
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

        if (buy.coin >= 150)
            Icon3.gameObject.SetActive(true);
        else
            Icon3.gameObject.SetActive(false);

        if(FItemGet == true)
            Icon4.gameObject.SetActive(true);
        else
            Icon4.gameObject.SetActive(false);

        if (CItemGet == true)
        {
            Icon5.gameObject.SetActive(true);
        }
        else
            Icon5.gameObject.SetActive(false);
    }
}
