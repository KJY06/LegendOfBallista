using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class SpawnFriendly : MonoBehaviour
{
    private Coin buy;
    [SerializeField] private GameObject Soldier;
    [SerializeField] private GameObject Elite;
    [SerializeField] private GameObject Boss;


    void Start()
    {
        buy = FindObjectOfType<Coin>();
    }

    void Update()
    {
        Bought();
    }

    
    void Bought()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            var vector2 = new Vector2(8.7f, Random.Range(-4.1f, 1.7f));
            if (buy.coin >= 15)
            {
                buy.coin -= 15;
                
                Instantiate(Soldier, vector2, quaternion.identity);
            }
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (buy.coin >= 25)
            {
                buy.coin -= 25;
                var vector2 = new Vector2(8.7f, Random.Range(-4.1f, 1.7f));
                Instantiate(Elite, vector2, quaternion.identity);
            }
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (buy.coin >= 150)
            {
                buy.coin -= 150;
                var vector2 = new Vector2(8.7f, Random.Range(-3.9f, 1.3f));
                Instantiate(Boss, vector2, quaternion.identity);
            }
        }
    }
}
