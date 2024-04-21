using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   
    [SerializeField] public List<WhiteBall> _whiteBalls = new List<WhiteBall>();
    [SerializeField] public List<RedBall> _redBalls = new List<RedBall>();
    [SerializeField] public List<GreenBall> _greenBalls = new List<GreenBall>();

    private IWinCondition _winCondition;
    [SerializeField] private GameObject _victoryMessage;

    public void PlayerCollisionDetected(GameObject gameObject)
    {
        if (gameObject.TryGetComponent(out RedBall redball))
        {
            _redBalls.Remove(redball);
            Destroy(gameObject);
            CheckWinCondition();
        }

        if (gameObject.TryGetComponent(out WhiteBall whiteball))
        {
            _whiteBalls.Remove(whiteball);
            Destroy(gameObject); 
            CheckWinCondition();

        }

        if (gameObject.TryGetComponent(out GreenBall greenball))
        {
            _greenBalls.Remove(greenball);
            Destroy(gameObject);
            CheckWinCondition();

        }
    }

    public void SetWinCondition(IWinCondition winCondition)
    {
        _winCondition = winCondition;
    }


    private void CheckWinCondition()
    {
        if (_winCondition.GotWinCondition(_whiteBalls, _redBalls, _greenBalls))
        {
            _victoryMessage.SetActive(true);
        }
    }

}
