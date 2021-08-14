using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartNomalGameScenes : MonoBehaviour
{
    public void RestartNomalGame()
    {
        SceneManager.LoadScene("NomalGameSubScenes");
    }
}
