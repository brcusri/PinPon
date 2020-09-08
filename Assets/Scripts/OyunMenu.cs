using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunMenu : MonoBehaviour
{
    public void LoadSahne(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            LoadSahne(0);
        }
    }
}
