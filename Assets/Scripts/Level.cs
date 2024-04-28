using System;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level
{
    public event Action Defeat;

    public void Start()
    {
        Debug.Log("Start");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnDefeat()
    {
        Defeat?.Invoke();
    }
}
