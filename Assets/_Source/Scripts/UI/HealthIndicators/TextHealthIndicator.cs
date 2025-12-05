using TMPro;
using UnityEngine;

public class TextHealthIndicator : HealthIndicator
{
    [SerializeField] private TextMeshProUGUI _text;

    protected override void Awake()
    {
        base.Awake();
        Display(Health.Value);
    }

    protected override void Display(int healthValue)
        => _text.text = $"{healthValue}/{Health.Max}";
}