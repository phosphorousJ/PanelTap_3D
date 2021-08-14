using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubScoreSaves : MonoBehaviour
{
    GameObject gameDirectorObject;

    GameDirector gameDirectorScript;

    public static int setSubCyanOffsetScore = 0;
    public static int setSubMagentaOffsetScore = 0;
    public static int setSubYellowOffsetScore = 0;
    public static int setSubTotalOffsetScore = 0;


    // Start is called before the first frame update
    void Start()
    {
        gameDirectorObject = GameObject.Find("GameDirector");

        gameDirectorScript = gameDirectorObject.GetComponent<GameDirector>();
    }


    // Update is called once per frame
    void Update()
    {
        setSubCyanOffsetScore = gameDirectorScript.cyanOffsetScore;

        setSubMagentaOffsetScore = gameDirectorScript.magentaOffsetScore;

        setSubYellowOffsetScore = gameDirectorScript.yellowOffsetScore;

        setSubTotalOffsetScore = gameDirectorScript.totalOffsetScore;
    }


    //ゲームリザルト画面（GameClearScenesとGameOverScenes）に保存したサブシアンスコアを渡す関数
    public static int GetSubCyanOffset()
    {
        return setSubCyanOffsetScore;
    }


    public static int GetSubMagentaOffset()
    {
        return setSubMagentaOffsetScore;
    }


    public static int GetSubYellowOffset()
    {
        return setSubYellowOffsetScore;
    }


    public static int GetSubTotalOffset()
    {
        return setSubTotalOffsetScore;
    }
}
