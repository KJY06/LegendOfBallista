using UnityEngine;

public class Remain : MonoBehaviour
{
    public int hp;
    public int coin;
    public bool Fitemget;
    public bool Citemget;
    public int point;
    public bool? IsNomal;
    private void Awake()
    {
        IsNomal = null;
        hp = 5;
        coin = 0;
        point = 0;
        Fitemget = false;
        Citemget = false;
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
            if(IsNomal != false)
                Destroy(gameObject);
        }
    }
}
