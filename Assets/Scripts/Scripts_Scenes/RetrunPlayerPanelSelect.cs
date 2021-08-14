using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetrunPlayerPanelSelect : MonoBehaviour
{
    public void RetrunPlayerPanel()
    {
        SceneManager.LoadScene("PlayerPanelDescripitionScenes");
    }
}
