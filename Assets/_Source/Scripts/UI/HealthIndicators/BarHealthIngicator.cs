using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Health))]
public class BarHealthIngicator : HealthIndicator
{
    [SerializeField] protected Slider Slider;

    protected override void Awake()
    {
        base.Awake();
        
        Slider.minValue = 0f;
        Slider.maxValue = Health.Max;
        Slider.value = Health.Value;
    }

    protected override void Display(int healthValue)
        => Slider.value = healthValue;
}