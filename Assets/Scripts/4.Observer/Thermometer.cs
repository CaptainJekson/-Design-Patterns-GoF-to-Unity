using UnityEngine;
using TMPro;

[RequireComponent(typeof(TMP_Text))]
public class Thermometer : MonoBehaviour
{
    [SerializeField] private Reactor _reactor;

    private TMP_Text _text;

    private void Awake()
    {
        _text = GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
        _reactor.TemperatureHasRisen += ShowTemperature;
    }

    private void OnDisable()
    {
        _reactor.TemperatureHasRisen -= ShowTemperature;
    }

    private void ShowTemperature(float value)
    {
        _text.text = string.Format("{0:f2}", value) + " °С";
    }
}
