using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private int hp;
    public int addpoint;
    private Coin coin;

    private void Start()
    {
        addpoint = hp;
        coin = FindObjectOfType<Coin>();
    }

    void Update()
    {
        MoveToTarget();
    }

    public void MoveToTarget()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Arrow") || collision.CompareTag("Friendly"))
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
