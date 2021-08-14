using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyPanelSelect : MonoBehaviour
{
    public void ClickEnemyPanel()
    {
        SceneManager.LoadScene("EnemyPanelDescripitionScenes");
    }
}
