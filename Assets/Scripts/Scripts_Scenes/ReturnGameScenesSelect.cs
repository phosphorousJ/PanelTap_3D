using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnGameScenesSelect : MonoBehaviour
{
    public void ReturnGameScenes()
    {
        SceneManager.LoadScene("HardGameScenes");
    }
}
