﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPanelController : MonoBehaviour
{
    //上昇する速さ
    private float upSpeed = -10.0f;

    //BluePanelの威力
    private int redPanelPw = 100;

    //貫通したパネルの初期枚数
    private int panelNum = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        //パネルを上昇させる
        transform.Translate(0, 0, 2 * upSpeed * Time.deltaTime);
    }


    void OnTriggerEnter(Collider other)
    {
        //EnemyPanelに衝突した場合
        if (other.gameObject.tag == "CyanPanelTag" || other.gameObject.tag == "MagentaPanelTag" || other.gameObject.tag == "YellowPanelTag")
        {
            //EnemyPanelを破棄
            Destroy(other.gameObject);
            Debug.Log("貫通");

            //貫通したパネルの枚数の更新
            panelNum++;

        }
        int RedPanelPower = redPanelPw - 10 * panelNum;
        Debug.Log(RedPanelPower + "ダメージを与えた");

        //敵(UpperWall)に衝突した場合
        if (other.gameObject.tag == "UpperWallTag")
        {
            //MyPanelを破棄
            Destroy(gameObject);
            Debug.Log("反撃");
        }
    }
}
