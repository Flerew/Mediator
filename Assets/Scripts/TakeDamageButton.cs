using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class TakeDamageButton : MonoBehaviour
{
    public event Action<int> TakeDamage;

    [SerializeField] private int _damage;

    private Button _button;

    private void OnEnable()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(Damage);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(Damage);
    }

    private void Damage()
    {
        TakeDamage?.Invoke(_damage);
    }
}
