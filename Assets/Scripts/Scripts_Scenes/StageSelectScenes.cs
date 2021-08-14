using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelectScenes : MonoBehaviour
{
    public void StageSelect()
    {
        SceneManager.LoadScene("StageSelectScenes");
    }
}
