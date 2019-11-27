﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("Layout");
        Time.timeScale = 1;
    }
    public void BackToMenu()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        Time.timeScale = 1;
        SceneManager.LoadScene("menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
