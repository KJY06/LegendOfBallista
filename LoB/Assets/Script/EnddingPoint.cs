using UnityEngine;
using UnityEngine.UI;

public class EnddingPoint : MonoBehaviour
{
    private EndlessPoint point;
    [SerializeField] private Text Result;
    void Start()
    {
        point = FindObjectOfType<EndlessPoint>();
        Result.text = $"Your Score : {point.point}";
    }

}
