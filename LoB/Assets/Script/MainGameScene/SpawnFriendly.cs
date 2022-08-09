using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnFriendly : MonoBehaviour
{
    private Coin buy;
    [SerializeField] private GameObject Soldier;
    [SerializeField] private GameObject Elite;
    [SerializeField] private GameObject Boss;

    private AudioSource au;
    void Start()
    {
        au = GetComponent<AudioSource>();
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
            if (buy.coin >= 15)
            {
                buy.coin -= 15;
                var vector2 = new Vector2(8.7f, Random.Range(-4.1f, 1.7f));
                au.Play();
                Instantiate(Soldier, vector2, quaternion.identity);
            }
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (buy.coin >= 45)
            {
                buy.coin -= 45;
                var vector2 = new Vector2(8.7f, Random.Range(-4.1f, 1.7f));
                au.Play();
                Instantiate(Elite, vector2, quaternion.identity);
            }
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (buy.coin >= 115)
            {
                buy.coin -= 115;
                var vector2 = new Vector2(8.7f, Random.Range(-3.9f, 1.3f));
                au.Play();
                Instantiate(Boss, vector2, quaternion.identity);
            }
        }
    }
}
