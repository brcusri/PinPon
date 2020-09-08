using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class player : MonoBehaviour
{
    string axName = "Horizontal2";
    public float playerhiz = 10;
    public Rigidbody2D bombpref;
    public Transform bombSp;
    float bombspeed = 500f;

    public Transform ballthrown;
    float dist;

    public abstract void LoadScore();

    public int Score;
    public Text scoretext,hisctext;
    public int highscore;
    



    void Start()
    {
        highscore = PlayerPrefs.GetInt("Highscr", 0);
        hisctext.text = highscore.ToString();
        LoadScore();
    }
    private void FixedUpdate()
    {
        float mAxis = Input.GetAxis(axName) * playerhiz;
        GetComponent<Rigidbody2D>().velocity = new Vector2(mAxis, 0);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            BombThrow();
        }
        dist = Vector2.Distance(transform.position, ballthrown.position);
        if(dist<2)
        {
            transform.position = new Vector2(0, -4);
        }
        
        
    }

    private void BombThrow()
    {

        var bomb = Instantiate(bombpref, bombSp.position, Quaternion.identity);
        bomb.AddForce(transform.up * bombspeed);


    }
    public void SkorYap()
    {
        Score++;
        scoretext.text = Score.ToString();
        if (Score > highscore)
        {
            highscore = Score;
            hisctext.text = highscore.ToString();
            PlayerPrefs.SetInt("Highscr", highscore);
            SavePlay();
            
        }
        if(Score%5==0)
        {
            transform.position = new Vector2(transform.position.x,transform.position.y+1);    
        }
    }
    public void SavePlay()
    {
        SaveLoadManager.Save(this);
    }
}
