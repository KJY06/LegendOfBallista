using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Castle : MonoBehaviour
{
   [SerializeField] private int hp;
   [SerializeField] private Text Hp;
   [SerializeField] private Sprite[] sprite = new Sprite[4];
    private SpriteRenderer spriteRenderer;
    private CameraShake shake;


    void Start()
    {
        Hp.text = $"Hp       : {hp}";
        spriteRenderer = GetComponent<SpriteRenderer>();
        shake = FindObjectOfType<CameraShake>();
    }
    void ChangeSprite()
    {
        if (hp > 3)
        {
            spriteRenderer.sprite = sprite[0];
        }
        if (hp == 3)
        {
            spriteRenderer.sprite = sprite[1];
        }
        if (hp == 2)
        {
            spriteRenderer.sprite = sprite[2];
        }
        if (hp <= 1)
        {
            spriteRenderer.sprite = sprite[3];
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Enemy"))
        {
            hp -= 1;
            Hp.text = $"Hp       : {hp}";
            shake.shakeCnt = 0;
        }
        if (collision.CompareTag("EliteEnemy"))
        {
            hp -= 2;
            Hp.text = $"Hp       : {hp}";
            shake.shakeCnt = 0;
        }
        if (collision.CompareTag("Boss"))
        {
            hp -= 5;
            Hp.text = $"Hp       : {hp}";
            shake.shakeCnt = 0;
        }
        if (hp <= 0)
        {
            SceneManager.LoadScene("End");
        }
        ChangeSprite();
    }
}
