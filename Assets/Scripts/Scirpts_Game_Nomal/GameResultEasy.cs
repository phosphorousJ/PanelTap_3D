using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameResultEasy : MonoBehaviour
{
    GameObject cyanScoreText;
    GameObject magentaScoreText;
    GameObject yellowScoreText;
    GameObject totalScoreText;


    // Start is called before the first frame update
    void Start()
    {
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
    }
}
