using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBall : Ball
{
    private GameManager _gameManager;
    private void Awake()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _color = Colors.Green;
        _gameManager._greenBalls.Add(this);
    }
}
