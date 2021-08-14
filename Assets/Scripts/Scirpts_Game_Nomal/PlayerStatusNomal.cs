using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStatusNomal : MonoBehaviour
{
    //Playerの最大HP
    private int maxHP = 3000;

    //Playerの現在HP
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
            SceneManager.LoadScene("NomalGameOverScenes");

            Debug.Log("Game Over");
        }
    }


    //被ダメージ値を取得する関数
    public void SetDamage(int playerDamage)
    {
        //現在のHPを更新
        currentHp = currentHp - playerDamage;

        //HPバーを更新
        hpSlider.value = (float)currentHp / (float)maxHP;
    }
}
