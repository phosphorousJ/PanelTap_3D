using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnHowPlaySelect : MonoBehaviour
{
    public void ClickReturnHowPlay()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
