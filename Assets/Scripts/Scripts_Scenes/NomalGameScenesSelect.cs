using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NomalGameScenesSelect : MonoBehaviour
{
    public void NomalGameScenes()
    {
        SceneManager.LoadScene("NomalGameSubScenes");
    }
}
