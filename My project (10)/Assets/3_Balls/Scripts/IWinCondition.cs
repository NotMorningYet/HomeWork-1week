using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWinCondition 
{
    bool GotWinCondition(List<WhiteBall> whiteBalls, List<RedBall> redBalls, List<GreenBall> _greenBalls);
}
