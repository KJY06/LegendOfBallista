using UnityEngine;

public class Friendly : MonoBehaviour
{
    [SerializeField] private int hp;
    [SerializeField] private float speed;

    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
            hp -= 1;
        if(collision.CompareTag("EliteEnemy"))
            hp -= 2;
        if (collision.CompareTag("Boss"))
            hp -= 5;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
