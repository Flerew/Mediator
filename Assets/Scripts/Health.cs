using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _health;

    public int CurrentHealth => _health;

    public event Action Death;

    public void TakeDamage(int damage)
    {   
        _health -= damage;

        if (_health <= 0)
        {
            Death?.Invoke();
        }
    }
}
