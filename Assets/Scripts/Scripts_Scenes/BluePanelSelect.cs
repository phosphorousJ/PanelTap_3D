using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BluePanelSelect : MonoBehaviour
{
    public void ClickBluePanel()
    {
        SceneManager.LoadScene("BluePanelDescripitionScenes");
    }
}
