using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScenesSelect : MonoBehaviour
{
    public void GameScense()
    {
        SceneManager.LoadScene("GameScenes");
    }
}
