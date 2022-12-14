using UnityEngine;

public class Remain : MonoBehaviour
{
    public int hp;
    public int coin;
    public bool Fitemget;
    public bool Citemget;
    public int point;
    public bool? IsNomal;
    public int BallistaLevel;
    private void Awake()
    {
        IsNomal = null;
        hp = 5;
        coin = 0;
        point = 0;
        Fitemget = false;
        Citemget = false;
        BallistaLevel = 0;
        DontDestroyOnLoad(this);
    }
    private void Start()
    {
        var obj = FindObjectsOfType<Remain>();

        if (obj.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if(IsNomal == true)
                Destroy(gameObject);
        }
    }
}
