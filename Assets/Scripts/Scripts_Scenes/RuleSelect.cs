using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RuleSelect : MonoBehaviour
{
    public void ClickRule()
    {
        SceneManager.LoadScene("RuleDescripitionScenes");
    }
}
