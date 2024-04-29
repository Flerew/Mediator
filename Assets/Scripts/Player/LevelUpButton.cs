using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class LevelUpButton : MonoBehaviour
{
    public event Action LevelUp;

    private Button _button;

    private void OnEnable()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(UpLevel);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(UpLevel);
    }

    private void UpLevel()
    {
        LevelUp?.Invoke();
    }
}
