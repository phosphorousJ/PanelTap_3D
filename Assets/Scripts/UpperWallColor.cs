using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperWallColor : MonoBehaviour
{
    //Materialを入れる
    Material myMaterial;

    //色が変わる時間間隔
    private float intervalTime = 10f;

    //経過時間
    private float time = 0f;


    // Start is called before the first frame update
    void Start()
    {
        //オブジェクトにアタッチしているMaterialを取得
        this.myMaterial = GetComponent<Renderer>().material;
    }


    // Update is called once per frame
    void Update()
    {
        //時間計測
        time += Time.deltaTime;

        if (time > intervalTime)
        {
            changeWallColor();
            //経過時間をリセット
            time = 0f;
        }
    }


    //UpperWallの色を変える
    void changeWallColor()
    {
        //変化させたい色の候補
        Color[] colors = new Color[] { Color.white, Color.blue, Color.red, Color.green };

        //色をランダムに取得
        Color color = colors[Random.Range(0, colors.Length)];

        //取得した色に設定
        this.GetComponent<Renderer>().material.color = color;
    }
}
