using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private float _health;

    private float _damage = 10;
    private float _treatment = 10;

    public event UnityAction<float> TookDamage;
    public event UnityAction<float> Healed;

    public float Health => _health;

    public void Damage()
    {
        _health -= _damage;
        TookDamage.Invoke(_health);
    }

    public void Treatment()
    {
        _health += _treatment;
        Healed.Invoke(_health);
    }
}
