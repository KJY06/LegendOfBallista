using Unity.Mathematics;
using Random = UnityEngine.Random;
using UnityEngine;

public class Generate : MonoBehaviour
{
    private EnemyCastle castle;
    [SerializeField] private GameObject Soldier;
    [SerializeField] private GameObject Elite;
    [SerializeField] private GameObject Boss;

    private float Mcurrenttime;
    [SerializeField] private float Mmaxtime;
    
    private float Ecurrenttime;
    [SerializeField] private float Emaxtime;

    private Remain re;
    
    public bool forspon = false;
    public int bosscnt = 0;

    private void Start()
    {
        re = FindObjectOfType<Remain>();
        castle = FindObjectOfType<EnemyCastle>();
        Mcurrenttime = 0;
        Ecurrenttime = 0;
    }
    void Update()
    {
        if(re.IsNomal == true)
        {
            if (castle.hp > 0)
            {
                Spon();
            }
        }
        if(re.IsNomal == false)
            Spon();

        forspon = false;
    }
    void Spon()
    {
        Mcurrenttime += Time.deltaTime;
        Ecurrenttime += Time.deltaTime;

        if (Mcurrenttime >= Mmaxtime)
        {
            Mcurrenttime = 0;
            var vector2 = new Vector2(-12f, Random.Range(-4.1f, 1.7f));
            Instantiate(Soldier, vector2, quaternion.identity);

        }

        if (Ecurrenttime >= Emaxtime)
        {
            Ecurrenttime = 0;
            var vector2 = new Vector2(-12f, Random.Range(-4.1f, 1.7f));
            Instantiate(Elite, vector2, quaternion.identity);
        }

        if (forspon == true && bosscnt == 0)
        {
            bosscnt++;
            forspon = false;
            var vector2 = new Vector2(-12f, Random.Range(-3.9f, 1.3f));
            Instantiate(Boss, vector2, quaternion.identity);
        }
    }
}

