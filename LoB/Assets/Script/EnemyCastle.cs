using UnityEngine;
using UnityEngine.UI;

public class EnemyCastle : MonoBehaviour
{
    public bool IsExist;
    [SerializeField] private int hp;
    [SerializeField] private Text Hptext;
    [SerializeField] private Sprite[] sprite = new Sprite[4];
    private SpriteRenderer spriteRenderer;
    private Generate gen;
    private CameraShake shake;

    void Start()
    {
        IsExist = true;
        Hptext.text = $"Hp       : {hp}";
        spriteRenderer = GetComponent<SpriteRenderer>();
        gen = FindObjectOfType<Generate>();
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
        if (collision.CompareTag("Friendly"))
        {
            hp -= 1;
            shake.shakeCnt = 0;
            Hptext.text = $"Hp       : {hp}";
        }
        if (collision.CompareTag("Elite"))
        {
            hp -= 2;
            shake.shakeCnt = 0;
            Hptext.text = $"Hp       : {hp}";
        }
        if (collision.CompareTag("BossFriendly"))
        {
            hp -= 5;
            shake.shakeCnt = 0;
            Hptext.text = $"Hp       : {hp}";
        }
        if (hp <= 0)
        {
            gen.IsCastleExist = false;
            Destroy(gameObject);
        }
        ChangeSprite();

    }
}
