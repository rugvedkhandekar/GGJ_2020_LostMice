﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public void ResumeGame()
    {

    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
