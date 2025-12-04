using UnityEngine;

public class HealerButton : HealthChangerButton
{
    [SerializeField, Min(0)] private int _minHealthValue = 10;
    [SerializeField, Min(0)] private int _maxHealthValue = 40;

    protected override void OnClick()
    {
        int healthValue = Random.Range(_minHealthValue, _maxHealthValue);
        Health.Heal(healthValue);
    }
}