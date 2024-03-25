using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameStatus 
{
    public enum GameLoop{
        paused,
        playing
    }

    public GameLoop gameLoop;

    public enum PlayerStatus{
        jump,
        ground,
        fall,
        death,
    }
    public PlayerStatus playerStatus;

    public GameStatus(){
        gameLoop = GameLoop.playing;
        playerStatus = PlayerStatus.ground;
    }
}
