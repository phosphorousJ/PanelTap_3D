using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameResult : MonoBehaviour
{
    GameObject cyanScoreText;
    GameObject magentaScoreText;
    GameObject yellowScoreText;
    GameObject totalScoreText;

    GameObject subCyanScoreText;
    GameObject subMagentaScoreText;
    GameObject subYellowScoreText;
    GameObject subTotalScoreText;


    // Start is called before the first frame update
    void Start()
    {
        //Stage1.1のスコアテキスト
        this.cyanScoreText = GameObject.Find("CyanScoreText");
        this.magentaScoreText = GameObject.Find("MagentaScoreText");
        this.yellowScoreText = GameObject.Find("YellowScoreText");
        this.totalScoreText = GameObject.Find("TotalScoreText");

        int resultCyanOffsetScores = ScoreSaves.GetCyanOffset();
        int resultMagentaOffsetScores = ScoreSaves.GetMagentaOffset();
        int resultYellowOffsetScores = ScoreSaves.GetYellowOffset();
        int resultTotalOffsetScores = ScoreSaves.GetTotalOffset();

        this.cyanScoreText.GetComponent<Text>().text = "Cyan      :" + resultCyanOffsetScores.ToString() + "offset";
        this.magentaScoreText.GetComponent<Text>().text = "Magenta:" + resultMagentaOffsetScores.ToString() + "offset";
        this.yellowScoreText.GetComponent<Text>().text = "Yellow    :" + resultYellowOffsetScores.ToString() + "offset";
        this.totalScoreText.GetComponent<Text>().text = "Total      :" + resultTotalOffsetScores.ToString() + "offset";


        //Stage1.2のスコアテキスト
        this.subCyanScoreText = GameObject.Find("SubCyanScoreText");
        this.subMagentaScoreText = GameObject.Find("SubMagentaScoreText");
        this.subYellowScoreText = GameObject.Find("SubYellowScoreText");
        this.subTotalScoreText = GameObject.Find("SubTotalScoreText");

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
