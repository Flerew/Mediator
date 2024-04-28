using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class PlayerLevelText : MonoBehaviour
{
    private TMP_Text _text;

    private void Awake()
    {
        _text = GetComponent<TMP_Text>();
    }

    public void UpdateText(int level)
    {
        _text.text = $"Level: {level}";
    }
}
