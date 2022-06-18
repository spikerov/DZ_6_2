using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Player _player;
    [SerializeField] private Button _damageButton;
    [SerializeField] private Button _treatmentButton;

    private float _damage = 10;
    private float _treatment = 10;
    private float _currentValue;
    private float _maxDeltaChangeHeath = 1;

    private void Start()
    {
        _slider.value = _player.Health;
    }

    private void Update()
    {
        _damageButton.onClick.AddListener(Damage);
        _treatmentButton.onClick.AddListener(Treatment);
    }

    public void Damage()
    {
        _currentValue = _slider.value - _damage;
        _slider.value = Mathf.MoveTowards(_slider.value, _currentValue, _maxDeltaChangeHeath * Time.deltaTime);
    }

    public void Treatment()
    {
        _currentValue = _slider.value + _treatment;
        _slider.value = Mathf.MoveTowards(_slider.value, _currentValue, _maxDeltaChangeHeath * Time.deltaTime);
    }
}
