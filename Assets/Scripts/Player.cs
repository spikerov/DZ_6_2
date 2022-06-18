using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private float _health;
    [SerializeField] private Slider _slider;

    private float _damage = 10;
    private float _treatment = 10;
    private float _maxHealth = 100;
    private float _minHeath = 0;

    public event UnityAction<float> ChangedHealth;

    public float Health => _health;

    private void Start()
    {
        _slider.value = _health;
    }

    public void TakeDamage()
    {
        if (_health != _minHeath)
        {
            _health -= _damage;
            ChangedHealth.Invoke(_health);
        }
    }

    public void Treatment()
    {
        if (_health != _maxHealth)
        {
            _health += _treatment;
            ChangedHealth.Invoke(_health);
        }
    }
}
