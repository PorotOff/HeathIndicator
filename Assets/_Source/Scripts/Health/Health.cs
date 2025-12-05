using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int _value;

    public event Action<int> Changed;

    public int Max => 100;
    public int Value
    {
        get => _value;

        private set
        {
            _value = value;
            Changed?.Invoke(_value);
        }
    }

    private void Awake()
        => Value = Max;

    public void TakeDamage(int damage)
    {
        if (damage > 0)
            Value = Mathf.Max(0, Value - damage);
    }

    public void Heal(int healthAmount)
    {
        if (healthAmount > 0)
            Value = Mathf.Min(Max, Value + healthAmount);
    }
}