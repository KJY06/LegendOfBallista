using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float arrowSpeed;
    private float time;
    private Castle castle;

    private void Start()
    {
        castle = FindObjectOfType<Castle>();
    }
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