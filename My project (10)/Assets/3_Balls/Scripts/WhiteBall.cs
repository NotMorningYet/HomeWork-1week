using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBall : Ball
{
    private GameManager _gameManager;
    private void Awake()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _color = Colors.White;
        _gameManager._whiteBalls.Add(this);
    }
}

