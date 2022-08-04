using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private int hp;
    private int addpoint;
    private Coin coin;
    private EnemyCastle castle;


    private void Start()
    {
        addpoint = hp;
        coin = FindObjectOfType<Coin>();
        castle = FindObjectOfType<EnemyCastle>();
    }

    void Update()
    {
        MoveToTarget();

        if(castle.hp <= 0)
            Destroy(gameObject);
    }

    public void MoveToTarget()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("FireArrow"))
        {
            hp = 0;
            coin.point += 4;
            coin.coin += 4;
        }

        if (collision.CompareTag("Friendly") || collision.CompareTag("Arrow"))
            hp -= 1;
        if (collision.CompareTag("Elite"))
            hp -= 2;
        if (collision.CompareTag("BossFriendly"))
            hp -= 5;

        if (hp <= 0)
        {
            coin.point += addpoint;
            coin.coin += addpoint;
            if(this.CompareTag("Boss"))
            {
                coin.coin += 3;
                coin.point += 3;
            }
            Destroy(gameObject);
        }
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
