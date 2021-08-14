using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowPlaySelect : MonoBehaviour
{
    public void ClickHowPlaySelect()
    {
        SceneManager.LoadScene("GameScreenDescripitionScenes");
    }
}
