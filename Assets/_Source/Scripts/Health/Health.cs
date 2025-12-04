using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int _healthValue;

    public event Action<int> Changed;
    public event Action BecameZero;

    public int MaxHealth => 100;
    public int HealthValue
    {
        get => _healthValue;

        set
        {
            _healthValue = value;
            Changed?.Invoke(_healthValue);
        }
    }

    public void TakeDamage(int damage)
    {
        if (damage > 0)
        {
            HealthValue = Mathf.Max(0, HealthValue - damage);

            if (HealthValue == 0)
                BecameZero?.Invoke();
        }
    }

    public void Heal(int healthAmount)
    {
        if (healthAmount > 0)
            HealthValue = Mathf.Min(MaxHealth, HealthValue + healthAmount);
    }
}