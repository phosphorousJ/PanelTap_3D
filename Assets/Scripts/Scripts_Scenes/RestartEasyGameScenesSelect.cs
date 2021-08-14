using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartEasyGameScenesSelect : MonoBehaviour
{
    public void RestartEasyGameScenes()
    {
        SceneManager.LoadScene("EasyGameScenes");
    }
}
