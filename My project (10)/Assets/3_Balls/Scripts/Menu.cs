using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private GameObject _world;
    public void StartGameAllColors()
    {
        _gameManager.SetWinCondition(new AllBallsWin());
        _world.SetActive(true);
        gameObject.SetActive(false);
    }

    public void StartGameOneColor()
    {
        _gameManager.SetWinCondition(new OneColorWin());
        _world.SetActive(true);
        gameObject.SetActive(false);
    }


}
