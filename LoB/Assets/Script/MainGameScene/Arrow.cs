using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] private float arrowSpeed;
    void Update()
    {
        transform.Translate(Vector3.up * arrowSpeed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy") || collision.CompareTag("EliteEnemy") || collision.CompareTag("Boss"))
        {
            Destroy(gameObject);
        }
    }
}