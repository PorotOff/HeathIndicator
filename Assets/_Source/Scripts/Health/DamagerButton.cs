using UnityEngine;

public class DamagerButton : HealthChangerButton
{
    [SerializeField, Min(0)] private int _minDamage = 10;
    [SerializeField, Min(0)] private int _maxDamage = 40;

    protected override void OnClick()
    {
        int damage = Random.Range(_minDamage, _maxDamage);
        Health.TakeDamage(damage);
    }
}