using UnityEngine;

public class GameReset : MonoBehaviour
{
    private Remain re;
    private void Awake()
    {
        re = FindObjectOfType<Remain>();
    }
    private void Start()
    {
        re.hp = 5;
        re.coin = 0;
        if(re.IsNomal == true)
            re.point = 0;
        re.Fitemget = false;
        re.Citemget = false;
        re.BallistaLevel = 0;
    }
}
