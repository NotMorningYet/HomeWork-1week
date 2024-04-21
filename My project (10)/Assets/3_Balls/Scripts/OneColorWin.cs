using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneColorWin : IWinCondition
{
    public bool GotWinCondition(List<WhiteBall> whiteBalls, List<RedBall> redBalls, List<GreenBall> greenBalls)
    {
        return (whiteBalls.Count == 0) | (redBalls.Count == 0) | (greenBalls.Count == 0);
    }
}
