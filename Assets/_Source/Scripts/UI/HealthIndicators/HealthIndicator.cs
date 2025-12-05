using UnityEngine;

[RequireComponent(typeof(Health))]
public abstract class HealthIndicator : MonoBehaviour
{
    protected Health Health;

    protected virtual void Awake()
        => Health = GetComponent<Health>();

    private void OnEnable()
        => Health.Changed += Display;

    private void OnDisable()
        => Health.Changed -= Display;

    protected abstract void Display(int healthValue);
}