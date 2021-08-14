using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagentaPanelConroller : MonoBehaviour
{
    //落下する速さ
    private float fallSpeed = 10.0f;

    //MagentaPanelの威力
    private int magentaPanelPw = 200;


    // Update is called once per frame
    void FixedUpdate()
    {
        //パネルを落下させる
        transform.Translate(0, 0, this.fallSpeed * Time.deltaTime);
    }


    //MagentaPanelが敵に与えるダメージ
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerStatus>())
        {
            if (other.gameObject.tag == "UnderWallTag")
            {
                //PlayerStatusスクリプトのSetDamage関数にダメージ値を渡す
                other.gameObject.GetComponent<PlayerStatus>().SetDamage(magentaPanelPw);

                //MagentaPanelを破棄
                Destroy(gameObject);
            }
        }

        if (other.gameObject.GetComponent<PlayerStatusEasy>())
        {
            if (other.gameObject.tag == "UnderWallTag")
            {
                //PlayerStatusEasyスクリプトのSetDamage関数にダメージ値を渡す
                other.gameObject.GetComponent<PlayerStatusEasy>().SetDamage(magentaPanelPw);

                //MagentaPanelを破棄
                Destroy(gameObject);
            }
        }

        if (other.gameObject.GetComponent<PlayerStatusNomal>())
        {
            if (other.gameObject.tag == "UnderWallTag")
            {
                //PlayerStatusEasyスクリプトのSetDamage関数にダメージ値を渡す
                other.gameObject.GetComponent<PlayerStatusNomal>().SetDamage(magentaPanelPw);

                //MagentaPanelを破棄
                Destroy(gameObject);
            }
        }
    }
}
