using UnityEngine;
public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private int hp;
    private int addpoint;
    private Coin coin;
    private EnemyCastle castle;
    private Remain re;

    private void Start()
    {
        re = FindObjectOfType<Remain>();
        addpoint = hp * 2;
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
        if (collision.CompareTag("Arrow"))
        {
            if (re.BallistaLevel == 0)
            {
                hp -= 1;
            }
            if (re.BallistaLevel == 1 || re.BallistaLevel == 2)
            {
                hp -= 2;
            }
            if (re.BallistaLevel == 3)
            {
                hp -= 3;
            }
            if (re.BallistaLevel == 4)
            {
                hp -= 4;
            }
            if (re.BallistaLevel == 5)
            {
                hp -= 5;
            }
        }
        if (collision.CompareTag("FireArrow"))
        {
            coin.point += 3;
            coin.coin += 3;
            hp = 0;
        }
        if (collision.CompareTag("Friendly"))
            hp -= 1;
        if (collision.CompareTag("Elite"))
            hp -= 2;
        if (collision.CompareTag("BossFriendly"))
            hp -= 5;

        if (hp <= 0)
        {
            coin.point += addpoint;
            coin.coin += addpoint;
            Destroy(gameObject);
        }
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
