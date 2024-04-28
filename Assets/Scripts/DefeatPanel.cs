using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefeatPanel : MonoBehaviour
{
    [SerializeField] private Button _restartButton;
    [SerializeField] private List<GameObject> UIElementsToHide;

    private GameMediator _mediator;

    private void OnEnable()
    {
        _restartButton.onClick.AddListener(OnRestartClick);
    }

    private void OnDisable()
    {
        _restartButton.onClick.RemoveListener(OnRestartClick);
    }

    public void Initialize(GameMediator mediator)
    {
        _mediator = mediator;
    }

    public void Show()
    {
        foreach (GameObject element in UIElementsToHide)
        {
            element.SetActive(false);
        }

        gameObject.SetActive(true);
    }
    public void Hide() => gameObject.SetActive(false);


    private void OnRestartClick()
    {
        _mediator.RestartLevel();
    }
}
