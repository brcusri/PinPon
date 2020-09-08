using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int score { get; private set; }
    public float playerposition;

    public PlayerData(player player)
    {
        score = player.Score;
        playerposition = player.transform.position.y;

    }
   
}
