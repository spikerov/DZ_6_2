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

    public event UnityAction<float> TookDamage;
    public event UnityAction<float> Healed;

    public float Health => _health;

    private void Start()
    {
        _slider.value = _health;
    }

    public void Damage()
    {
        if (_health != _minHeath)
        {
            _health -= _damage;
            TookDamage.Invoke(_health);
        }
    }

    public void Treatment()
    {
        if (_health != _maxHealth)
        {
            _health += _treatment;
            Healed.Invoke(_health);
        }
    }
}
