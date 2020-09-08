using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static bool GamePause = false;
    public GameObject menuManager;
    public void Load(int index)
    {
        SceneManager.LoadScene(index);
    }
   
    public void Quit()
    {
        Application.Quit();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GamePause)
            {
                Rasume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        menuManager.SetActive(true);
        Time.timeScale = 0f;
        GamePause = true;
    }

    public void Rasume()
    {
        
        menuManager.SetActive(false);
        Time.timeScale = 1f;
        GamePause = false;
    }
}
