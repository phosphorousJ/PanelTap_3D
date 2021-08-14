using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyStatusSub : MonoBehaviour
{
    //敵の最大HP
    private int maxHP = 3000;

    //敵の現在HP
    private int currentHp;

    //HPバー（Slider）を入れる
    public Slider hpSubSlider;


    // Start is called before the first frame update
    void Start()
    {
        //HPバーを満タンにする
        hpSubSlider.value = 1;

        //現在のHPを最大HPにする
        currentHp = maxHP;
    }


    // Update is called once per frame
    void Update()
    {
        if (hpSubSlider.value <= 0)
        {
            SceneManager.LoadScene("GameClearSubScenes");

            Debug.Log("Game Clear!!");
        }
    }


    //被ダメージ値を取得する関数
    public void SetDamage(int enemyDamage)
    {
        //現在のHPを更新
        currentHp = currentHp - enemyDamage;

        //HPバーを更新
        hpSubSlider.value = (float)currentHp / (float)maxHP; 
    }
}