using System;
using UnityEngine;

public class GameMediator : MonoBehaviour
{
    [SerializeField] private DefeatPanel _defeatPanel;
    [SerializeField] private LevelUpButton _playerLevelUpButton;
    [SerializeField] private TakeDamageButton _playerTakeDamageButton;
    [SerializeField] private PlayerLevelText _playerLevelText;
    [SerializeField] private HealthText _healthText;

    private Level _level;
    private Health _health;
    private PlayerLevel _playerLevel;

    public void Initialize(Level level, Health health, PlayerLevel playerLevel) 
    {
        _level = level;
        _health = health;
        _playerLevel = playerLevel;

        LevelUp();
        UpdateHealthText(health.CurrentHealth);

        _playerTakeDamageButton.TakeDamage += TakeDamage;
        _playerLevelUpButton.LevelUp += LevelUp;
        _health.Death += OnLevelDefeat;
    }


    private void OnDestroy()
    {
        _playerLevelUpButton.LevelUp -= LevelUp;
        _health.Death -= OnLevelDefeat;
    }
    public void RestartLevel()
    {
        _level.Restart();
    }

    private void TakeDamage(int damage)
    {
        _health.TakeDamage(damage);
        UpdateHealthText(_health.CurrentHealth);
    }

    private void LevelUp()
    {
        _playerLevel.LevelUp();
        _playerLevelText.UpdateText(_playerLevel.Level);
    }

    private void OnLevelDefeat()
    {
        _defeatPanel.Show();
        _level.OnDefeat();
    }


    private void UpdateHealthText(int health)
    {
        _healthText.UpdateText(health);
    }
}
