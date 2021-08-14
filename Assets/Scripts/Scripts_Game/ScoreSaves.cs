using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSaves : MonoBehaviour
{
    GameObject gameDirectorObject;

    GameDirector gameDirectorScript;

    public static int setCyanOffsetScore = 0;
    public static int setMagentaOffsetScore = 0;
    public static int setYellowOffsetScore = 0;
    public static int setTotalOffsetScore = 0;


    void Start()
    {
        gameDirectorObject = GameObject.Find("GameDirector");

        gameDirectorScript = gameDirectorObject.GetComponent<GameDirector>();
    }


    void Update()
    {
        //GameDirectorスクリプトの変数cyanOffsetScore（シアンスコア）を保存
        setCyanOffsetScore = gameDirectorScript.cyanOffsetScore;

        setMagentaOffsetScore = gameDirectorScript.magentaOffsetScore;

        setYellowOffsetScore = gameDirectorScript.yellowOffsetScore;

        setTotalOffsetScore = gameDirectorScript.totalOffsetScore;
    }


    //ゲームリザルト画面（GameClearScenesとGameOverScenes）に保存したシアンスコアを渡す関数
    public static int GetCyanOffset()
    {
        return setCyanOffsetScore;
    }


    public static int GetMagentaOffset()
    {
        return setMagentaOffsetScore;
    }


    public static int GetYellowOffset()
    {
        return setYellowOffsetScore;
    }


    public static int GetTotalOffset()
    {
        return setTotalOffsetScore;
    }
}