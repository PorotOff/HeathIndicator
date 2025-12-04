using TMPro;
using UnityEngine;

[RequireComponent(typeof(Health))]
public class TextHealthIndicator : MonoBehaviour, IHealthIndicator
{
    [SerializeField] private TextMeshProUGUI _text;

    private Health _health;

    private void Awake()
        => _health = GetComponent<Health>();

    private void OnEnable()
        => _health.Changed += Display;

    private void OnDisable()
        => _health.Changed -= Display;

    public void Display(int healthValue)
        => _text.text = $"{_health.HealthValue}/{_health.MaxHealth}";
}