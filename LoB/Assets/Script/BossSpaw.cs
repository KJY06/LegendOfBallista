using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpaw : MonoBehaviour
{
    private Coin coin;

    private void Start()
    {
        coin = FindObjectOfType<Coin>();
    }
    private void OnDestroy()
    {
        coin.point += 3;
        coin.point += 3;
        coin.pointcnt = 0;
    }
}
