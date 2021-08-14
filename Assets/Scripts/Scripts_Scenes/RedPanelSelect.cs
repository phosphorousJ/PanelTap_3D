using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedPanelSelect : MonoBehaviour
{
    public void ClickRedPanel()
    {
        SceneManager.LoadScene("RedPanelDescripitionScenes");
    }
}
