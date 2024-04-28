using TMPro;
using UnityEngine;

public class HealthText : MonoBehaviour
{
    [SerializeField] private TMP_Text _healthText;

    public void UpdateText(int health)
    {
        _healthText.text = $"Health: {health}";
    }
}
