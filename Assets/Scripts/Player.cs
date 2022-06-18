using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _health;

    public float Health => _health;

}
