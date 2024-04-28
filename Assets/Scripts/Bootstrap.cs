using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Bootstrap : MonoBehaviour
{
    [SerializeField] private GameMediator _gameMediator;
    [SerializeField] private Health _playerHealth;
    [SerializeField] private DefeatPanel _defeatPanel;
    
    private Level _level;
    private PlayerLevel _playerLevel;

    private void Awake()
    {
        _level = new Level();
        _playerLevel = new PlayerLevel();

        _gameMediator.Initialize(_level, _playerHealth, _playerLevel);
        _defeatPanel.Initialize(_gameMediator);

        _level.Start();
    }
}
