using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    private int minute = 0;
    private float seconds = 0f;
    private float oldSeconds = 0f;

    //TimerTextを入れる
    GameObject timerText;

    //CyanOffsetScoreテキストを入れる
    GameObject cyanOffsetScoreText;

    //CyanOffsetScoreの初期スコア
    public int cyanOffsetScore = 0;

    //MagentaOffsetScoreテキストを入れる
    GameObject magentaOffsetScoreText;

    //MagentaOffsetScoreの初期スコア
    public int magentaOffsetScore = 0;

    //YellowOffsetScoreテキストを入れる
    GameObject yellowOffsetScoreText;

    //YellowOffsetScoreの初期スコア
    public int yellowOffsetScore = 0;

    //TotalOffsetScoreテキストを入れる
    GameObject totalOffsetScoreText;

    //TotalOffsetScoreの初期スコア
    public int totalOffsetScore = 0;


    // Start is called before the first frame update
    void Start()
    {
        this.timerText = GameObject.Find("TimerText");

        this.cyanOffsetScoreText = GameObject.Find("CyanOffsetScoreText");

        this.magentaOffsetScoreText = GameObject.Find("MagentaOffsetScoreText");

        this.yellowOffsetScoreText = GameObject.Find("YellowOffsetScoreText");

        this.totalOffsetScoreText = GameObject.Find("ToatalOffsetScoreText");
    }


    // Update is called once per frame
    void Update()
    {
        Timer();

        //CyanOffsetScoreをテキストで表示する
        this.cyanOffsetScoreText.GetComponent<Text>().text = "C:" + this.cyanOffsetScore.ToString();

        //MagentaOffsetScoreをテキストで表示する
        this.magentaOffsetScoreText.GetComponent<Text>().text = "M:" + this.magentaOffsetScore.ToString();

        //YellowOffsetScoreをテキストで表示する
        this.yellowOffsetScoreText.GetComponent<Text>().text = "Y:" + this.yellowOffsetScore.ToString();

        //TotalOffsetScoreをテキストで表示する
        this.totalOffsetScoreText.GetComponent<Text>().text = this.totalOffsetScore.ToString();
    }


    //CyanOffsetScoreを更新する関数
    public int CyanOffset()
    {
        return this.cyanOffsetScore++;
    }


    //MagentaOffsetScoreを更新する関数
    public int MagentaOffset()
    {
        return this.magentaOffsetScore++;
    }


    //YellowOffsetScoreを更新する関数
    public int YellowOffset()
    {
        return this.yellowOffsetScore++;
    }

    //TotalOffsetScoreを更新する関数
    public int TotalOffset()
    {
        return this.totalOffsetScore++;
    }


    //TimerTextを更新する関数
    void Timer()
    {
        seconds += Time.deltaTime;

        //minituを更新
        if (seconds >= 60f)
        {
            minute++;
            seconds = seconds - 60;
        }

        //TimerTextをテキストで表示
        if ((int)seconds != (int)oldSeconds)
        {
            this.timerText.GetComponent<Text>().text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        }

        oldSeconds = seconds;
    } 
}
