using UnityEngine;

public class SpawnIcon : MonoBehaviour
{
    private SpriteRenderer sprite;
    [SerializeField] private int NeedCoin;
    private Coin buy;
    void Start()
    {
        buy = FindObjectOfType<Coin>();
    }

    void Update()
    {
        if (buy.coin >= NeedCoin)
            IsPossible();
        else
            IsImpossible();
    }
    void IsPossible()
    {
        sprite.color = new Color(1, 1, 1, 1);
    }

    void IsImpossible()
    {
        sprite.color = new Color(1, 1, 1, 0.4f);
    }
}
