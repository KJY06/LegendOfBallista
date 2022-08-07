using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] private float arrowSpeed;
    [SerializeField] private Sprite[] sprite = new Sprite[2];
    SpriteRenderer spriterenderer;
    public int Attack;

    private Remain re;
    private void Awake()
    {
        Attack = 1;
        re = FindObjectOfType<Remain>();
        spriterenderer = GetComponent<SpriteRenderer>();

        if (re.BallistaLevel == 5)
            spriterenderer.sprite = sprite[1];
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