using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameResultNomal : MonoBehaviour
{
    GameObject subCyanScoreText;
    GameObject subMagentaScoreText;
    GameObject subYellowScoreText;
    GameObject subTotalScoreText;


    // Start is called before the first frame update
    void Start()
    {
        this.subCyanScoreText = GameObject.Find("CyanScoreText");
        this.subMagentaScoreText = GameObject.Find("MagentaScoreText");
        this.subYellowScoreText = GameObject.Find("YellowScoreText");
        this.subTotalScoreText = GameObject.Find("TotalScoreText");

        int resultSubCyanOffsetScores = SubScoreSaves.GetSubCyanOffset();
        int resultSubMagentaOffsetScores = SubScoreSaves.GetSubMagentaOffset();
        int resultSubYellowOffsetScores = SubScoreSaves.GetSubYellowOffset();
        int resultSubTotalOffsetScores = SubScoreSaves.GetSubTotalOffset();

        this.subCyanScoreText.GetComponent<Text>().text = "Cyan      :" + resultSubCyanOffsetScores.ToString() + "offset";
        this.subMagentaScoreText.GetComponent<Text>().text = "Magenta:" + resultSubMagentaOffsetScores.ToString() + "offset";
        this.subYellowScoreText.GetComponent<Text>().text = "Yellow    :" + resultSubYellowOffsetScores.ToString() + "offset";
        this.subTotalScoreText.GetComponent<Text>().text = "Total      :" + resultSubTotalOffsetScores.ToString() + "offset";
    }
}
