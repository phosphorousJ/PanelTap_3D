﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetrunMenuSelect : MonoBehaviour
{
    public void ReturnMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
