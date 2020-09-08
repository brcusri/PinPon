using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewGame : player
{
    player oyuncu;
    public override void LoadScore()
    {
        oyuncu.transform.position = new Vector2(0, -4);
    }

}
