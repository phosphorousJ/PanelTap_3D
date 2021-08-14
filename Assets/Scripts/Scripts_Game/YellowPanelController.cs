using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPanelController : MonoBehaviour
{
    //落下する速さ
    private float fallSpeed = 10.0f;

    //YellowPanelの威力
    private int yellowPanelPw = 400;


    // Update is called once per frame
    void FixedUpdate()
    {
        //パネルを落下させる
        transform.Translate(0, 0, this.fallSpeed * Time.deltaTime);
    }


    //YellowPanelが敵に与えるダメージ
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerStatus>())
        {
            if (other.gameObject.tag == "UnderWallTag")
            {
                //PlayerStatusスクリプトのSetDamage関数にダメージ値を渡す
                other.gameObject.GetComponent<PlayerStatus>().SetDamage(yellowPanelPw);

                //YellowPanelを破棄
                Destroy(gameObject);
            }
        }

        if (other.gameObject.GetComponent<PlayerStatusEasy>())
        {
            if (other.gameObject.tag == "UnderWallTag")
            {
                //PlayerStatusEasyスクリプトのSetDamage関数にダメージ値を渡す
                other.gameObject.GetComponent<PlayerStatusEasy>().SetDamage(yellowPanelPw);

                //YellowPanelを破棄
                Destroy(gameObject);
            }
        }

        if (other.gameObject.GetComponent<PlayerStatusNomal>())
        {
            if (other.gameObject.tag == "UnderWallTag")
            {
                //PlayerStatusNomalスクリプトのSetDamage関数にダメージ値を渡す
                other.gameObject.GetComponent<PlayerStatusNomal>().SetDamage(yellowPanelPw);

                //YellowPanelを破棄
                Destroy(gameObject);
            }
        }
    }
}
