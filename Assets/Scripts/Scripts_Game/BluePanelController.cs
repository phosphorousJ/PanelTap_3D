using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePanelController : MonoBehaviour
{
    //上昇する速さ
    private float upSpeed = -10.0f;

    //BluePanelの威力
    private int bluePanelPw = 50;

    //貫通したパネルの初期枚数
    private int panelNum = 0;

    //GameDirectorオブジェクトを入れる
    GameObject gameDirector;


    // Start is called before the first frame update
    void Start()
    {
        //GameDirectorスクリプトがアタッチされているGameDirectorオブジェクトを取得
        this.gameDirector = GameObject.Find("GameDirector");   
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        //パネルを上昇させる
        transform.Translate(0, 0, upSpeed * Time.deltaTime);
    }


    void OnTriggerEnter(Collider other)
    {
        //CyanPanelに衝突した場合
        if (other.gameObject.tag == "CyanPanelTag")
        {
            //GameDirectorスクリプトのCyanOffset関数を呼び出す
            this.gameDirector.GetComponent<GameDirector>().CyanOffset();

            //GameDirectorスクリプトのTotalOffset関数を呼び出す
            this.gameDirector.GetComponent<GameDirector>().TotalOffset();

            //CyanPanelを破棄
            Destroy(other.gameObject);
            Debug.Log("破棄");
        }
        else if (other.gameObject.tag == "MagentaPanelTag")
        {
            //GameDirectorスクリプトのMagentaOffset関数を呼び出す
            this.gameDirector.GetComponent<GameDirector>().MagentaOffset();

            //GameDirectorスクリプトのTotalOffset関数を呼び出す
            this.gameDirector.GetComponent<GameDirector>().TotalOffset();

            //MagentaPanelを貫通
            Destroy(other.gameObject);
            Debug.Log("貫通");

            //貫通したパネルの枚数の更新
            panelNum++;
        }
        else if (other.gameObject.tag == "YellowPanelTag")
        {
            //GameDirectorスクリプトのYellowOffset関数を呼び出す
            this.gameDirector.GetComponent<GameDirector>().YellowOffset();

            //GameDirectorスクリプトのTotalOffset関数を呼び出す
            this.gameDirector.GetComponent<GameDirector>().TotalOffset();

            //YellowPanelを貫通
            Destroy(other.gameObject);
            Debug.Log("貫通");

            //貫通したパネルの枚数の更新
            panelNum++;
        }


        //BluePanelが敵に与えるダメージ
        if (other.gameObject.GetComponent<EnemyStatus>())
        {
            //敵(UpperWall)に衝突した場合
            if (other.gameObject.tag == "UpperWallTag")
            {
                int damage = bluePanelPw - 10 * panelNum;

                //UpperWallが青色の場合,2倍のダメージを与える
                if (other.gameObject.GetComponent<Renderer>().material.color == Color.blue)
                {
                    int timesDamage = 2 * damage;

                    //EnemyStatusスクリプトのSetDamage関数にダメージ値を渡す
                    other.gameObject.GetComponent<EnemyStatus>().SetDamage(timesDamage);

                    //BluePanelを破棄
                    Destroy(gameObject);
                    Debug.Log(timesDamage + "ダメージを与えた");
                }
                else
                {
                    //EnemyStatusスクリプトのSetDamage関数にダメージ値を渡す
                    other.gameObject.GetComponent<EnemyStatus>().SetDamage(damage);

                    //BluePanelを破棄
                    Destroy(gameObject);
                    Debug.Log(damage + "ダメージを与えた");
                }
            }
        }


        //BluePanelが敵（サブ）に与えるダメージ
        if (other.gameObject.GetComponent<EnemyStatusSub>())
        {
            //敵(UpperWall)に衝突した場合
            if (other.gameObject.tag == "UpperWallTag")
            {
                int damage = bluePanelPw - 10 * panelNum;

                //UpperWallが青色の場合,2倍のダメージを与える
                if (other.gameObject.GetComponent<Renderer>().material.color == Color.blue)
                {
                    int timesDamage = 2 * damage;

                    //EnemyStatusSubスクリプトのSetDamage関数にダメージ値を渡す
                    other.gameObject.GetComponent<EnemyStatusSub>().SetDamage(timesDamage);

                    //BluePanelを破棄
                    Destroy(gameObject);
                    Debug.Log(timesDamage + "ダメージを与えた");
                }
                else
                {
                    //EnemyStatusSubスクリプトのSetDamage関数にダメージ値を渡す
                    other.gameObject.GetComponent<EnemyStatusSub>().SetDamage(damage);

                    //BluePanelを破棄
                    Destroy(gameObject);
                    Debug.Log(damage + "ダメージを与えた");
                }
            }
        }


        //BluePanelが敵（easy）に与えるダメージ
        if (other.gameObject.GetComponent<EnemyStatusEasy>())
        {
            //敵(UpperWall)に衝突した場合
            if (other.gameObject.tag == "UpperWallTag")
            {
                int damage = bluePanelPw - 10 * panelNum;

                //UpperWallが青色の場合,2倍のダメージを与える
                if (other.gameObject.GetComponent<Renderer>().material.color == Color.blue)
                {
                    int timesDamage = 2 * damage;

                    //EnemyStatusスクリプトのSetDamage関数にダメージ値を渡す
                    other.gameObject.GetComponent<EnemyStatusEasy>().SetDamage(timesDamage);

                    //BluePanelを破棄
                    Destroy(gameObject);
                    Debug.Log(timesDamage + "ダメージを与えた");
                }
                else
                {
                    //EnemyStatusスクリプトのSetDamage関数にダメージ値を渡す
                    other.gameObject.GetComponent<EnemyStatusEasy>().SetDamage(damage);

                    //BluePanelを破棄
                    Destroy(gameObject);
                    Debug.Log(damage + "ダメージを与えた");
                }
            }
        }


        //BluePanelが敵（nomal）に与えるダメージ
        if (other.gameObject.GetComponent<EnemyStatusNomal>())
        {
            //敵(UpperWall)に衝突した場合
            if (other.gameObject.tag == "UpperWallTag")
            {
                int damage = bluePanelPw - 10 * panelNum;

                //UpperWallが青色の場合,2倍のダメージを与える
                if (other.gameObject.GetComponent<Renderer>().material.color == Color.blue)
                {
                    int timesDamage = 2 * damage;

                    //EnemyStatusスクリプトのSetDamage関数にダメージ値を渡す
                    other.gameObject.GetComponent<EnemyStatusNomal>().SetDamage(timesDamage);

                    //BluePanelを破棄
                    Destroy(gameObject);
                    Debug.Log(timesDamage + "ダメージを与えた");
                }
                else
                {
                    //EnemyStatusスクリプトのSetDamage関数にダメージ値を渡す
                    other.gameObject.GetComponent<EnemyStatusNomal>().SetDamage(damage);

                    //BluePanelを破棄
                    Destroy(gameObject);
                    Debug.Log(damage + "ダメージを与えた");
                }
            }
        }
    }
}
