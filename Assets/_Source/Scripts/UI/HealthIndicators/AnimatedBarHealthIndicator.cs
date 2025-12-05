using System.Collections;
using UnityEngine;

public class AnimatedBarHealthIndicator : BarHealthIngicator
{
    [SerializeField] private float _interpolationStep;

    private Coroutine _coroutine;

    protected override void Display(int healthValue)
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(UpdateHealth(healthValue));
    }

    private IEnumerator UpdateHealth(int healthValue)
    {
        while (Slider.value != healthValue)
        {
            Slider.value = Mathf.Lerp(Slider.value, healthValue, _interpolationStep);
            yield return null;
        }
    }
}