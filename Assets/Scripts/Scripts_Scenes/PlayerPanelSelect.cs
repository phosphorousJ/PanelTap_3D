using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPanelSelect : MonoBehaviour
{
    public void ClickPlayerPanel()
    {
        SceneManager.LoadScene("PlayerPanelDescripitionScenes");
    }
}
