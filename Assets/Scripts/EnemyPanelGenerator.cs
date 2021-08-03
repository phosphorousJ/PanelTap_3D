using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPanelGenerator : MonoBehaviour
{
    //CyanPanelPrefabを入れる
    public GameObject CyanPanelPrefab;

    //MagentaPanelPrefabを入れる
    public GameObject MagentaPanelPrefab;

    //YellowPanelPrefabを入れる
    public GameObject YellowPanelPrefab;

    //スタート地点
    private float startPosZ = 30;
    private float startPosY = 19.2f;

    //パネルを出すx方向の範囲
    private float posRange = 3.2f;

    //パネル生成時間間隔
    private float intervalTime;

    //経過時間
    private float time = 0f;

    //YellowPanelの生成個数の上限
    private int maxYellowPanelNum = 4;


    // Start is called before the first frame update
    void Start()
    {
        intervalTime = GetRandomTime();
    }


    // Update is called once per frame
    void Update()
    {
        //時間計測
        time += Time.deltaTime;

        //経過時間が生成時間より大きくなった時、パネルを生成
        if (time > intervalTime)
        {
            GenPanel();
            //経過時間をリセット
            time = 0f;
            //次の時間間隔を決定
            intervalTime = GetRandomTime();
        }
    }


    //パネルを生成する関数
    void GenPanel()
    {
        //パネルの種類を決める
        int panel = Random.Range(1, 11);

        //x座標をランダムに決定
        float laneX = posRange * Random.Range(-2, 3);

        //70%シアン生成:25%マゼンタ生成:05%イエロー生成
        if (1 <= panel && panel <= 7)
        {
            GameObject cyan = Instantiate(CyanPanelPrefab);
            cyan.transform.position = new Vector3(laneX, startPosY, startPosZ);
        }
        else if (7 <= panel && panel <= 9.5)
        {
            GameObject magenta = Instantiate(MagentaPanelPrefab);
            magenta.transform.position = new Vector3(laneX, startPosY, startPosZ);
        }
        else
        {
            //生成するYellowPanelの数をランダムに決定
            int n = Random.Range(2, maxYellowPanelNum + 1);

            //指定した数だけYellowPanelを生成する
            for (int i = 0; i < n; i++)
            {
                GameObject yellow = Instantiate(YellowPanelPrefab);
                yellow.transform.position = new Vector3(laneX, startPosY + 1.225f * i, startPosZ + 1.565f * i);
            }
        }
    }


    //ランダムな時間を決定する関数
    private float GetRandomTime()
    {
        return Random.Range(0.8f, 1.0f);
    }
}
