using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Health))]
public class BarHealthIngicator : MonoBehaviour, IHealthIndicator
{
    [SerializeField] protected Slider Slider;

    private Health _health;

    private void Awake()
    {
        _health = GetComponent<Health>();

        Slider.minValue = 0f;
        Slider.maxValue = _health.MaxHealth;
        Slider.value = _health.HealthValue;
    }

    private void OnEnable()
        => _health.Changed += Display;

    private void OnDisable()
        => _health.Changed -= Display;

    public virtual void Display(int healthValue)
        => Slider.value = healthValue;
}