﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelect : MonoBehaviour
{

    public void LoadScenebyIndex(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }

    
}
