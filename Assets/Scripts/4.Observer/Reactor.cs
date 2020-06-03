using System;
using System.Collections;
using UnityEngine;

[ExecuteInEditMode]
public class Reactor : MonoBehaviour
{
    [SerializeField] private float _temperature;
    [SerializeField] private float _temperatureIncreaseForSecond;

    public event Action<float> TemperatureHasRisen;

    private void Start()
    {
        StartCoroutine(ReactorHeating());
    }

    private IEnumerator ReactorHeating()
    {
        yield return new WaitForSeconds(1);
        _temperature += _temperatureIncreaseForSecond;
        TemperatureHasRisen?.Invoke(_temperature);

        StartCoroutine(ReactorHeating());
    }
}
