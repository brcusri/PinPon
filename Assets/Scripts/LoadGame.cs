using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadGame : player
{
    PlayerData playerLoad;
    player oyuncu;
    public override void LoadScore()
    {
        playerLoad = SaveLoadManager.Load();
        oyuncu.Score = playerLoad.score;
        float y = playerLoad.playerposition;
        oyuncu.transform.position = new Vector2(0, y);
    }

}
