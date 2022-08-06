using UnityEngine;
using UnityEngine.UI;

public class EndlessPoint : MonoBehaviour
{
    public int point;
    [SerializeField] private Text re;
    void Start()
    {
        DontDestroyOnLoad(this);
    }
}
