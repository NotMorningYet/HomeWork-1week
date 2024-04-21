using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RedBall : Ball
{
   private GameManager _gameManager;

    private void Awake()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _color = Colors.Red;
        _gameManager._redBalls.Add(this);
    }


}

