using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyStatusNomal : MonoBehaviour
{
    //敵の最大HP
    private int maxHP = 3000;

    //敵の現在HP
    private int currentHp;

    //HPバー（Slider）を入れる
    public Slider hpSlider;


    // Start is called before the first frame update
    void Start()
    {
        //HPバーを満タンにする
        hpSlider.value = 1;

        //現在のHPを最大HPにする
        currentHp = maxHP;
    }


    // Update is called once per frame
    void Update()
    {
        if (hpSlider.value <= 0)
        {
            SceneManager.LoadScene("NomalGameClearScenes");
        }
    }


    //被ダメージ値を取得する関数
    public void SetDamage(int enemyDamage)
    {
        //現在のHPを更新
        currentHp = currentHp - enemyDamage;

        //HPバーを更新
        hpSlider.value = (float)currentHp / (float)maxHP;
    }
}
