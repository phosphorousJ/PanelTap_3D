using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPanelController : MonoBehaviour
{
    //CyanPanelPrefabを入れる
    public GameObject CyanPanelPrefab;

    //MagentaPanelPrefabを入れる
    public GameObject MagentaPanelPrefab;

    //YellowPanelPrefabを入れる
    public GameObject YellowPanelPrefab;

    //落下する速さ
    private float fallSpeed = 10.0f;

    //消滅位置
    private float deadLine = -2.0f;

    //CyanPanelの威力
    private int cyanPanelPw = 100;

    //MagentaPanelの威力
    private int magentaPanelPw = 200;

    //YellowPanelの威力
    private int yellowPanelPw = 400;

    GameObject playerObject;


    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.Find("PlayerObject");
    }


    void FixedUpdate()
    {
        //パネルを落下させる
        transform.Translate(0, 0, this.fallSpeed * Time.deltaTime);
    }


    void OnTriggerEnter(Collider other)
    {
        if (gameObject.GetComponent<PlayerStatus>())
        {
            //敵(UpperWall)に衝突した場合
            if (other.gameObject.tag == "UnderWallTag")
            {
                if (CyanPanelPrefab)
                {
                    //PlayerStatusスクリプトのSetDamage関数にダメージ値を渡す
                    other.gameObject.GetComponent<PlayerStatus>().SetDamage(cyanPanelPw);

                    //CyanPanelを破棄
                    Destroy(CyanPanelPrefab);
                }
            }
        }
            
       
    }

    void Attack()
    {
        if (gameObject.GetComponent<PlayerStatus>())
        {
            //画面外に出たら破棄する
            if (transform.position.z < this.deadLine)
            {
                if (gameObject.tag == "CyanPanelTag")
                {
                    //PlayerStatusスクリプトのSetDamage関数にダメージ値を渡す
                    gameObject.GetComponent<PlayerStatus>().SetDamage(cyanPanelPw);

                    //CyanPanelを破棄
                    Destroy(gameObject);
                }
                else if (gameObject.tag == "MagentaPanelTag")
                {
                    //PlayerStatusスクリプトのSetDamage関数にダメージ値を渡す
                    gameObject.GetComponent<PlayerStatus>().SetDamage(magentaPanelPw);

                    //MagentaPanelを破棄
                    Destroy(gameObject);
                }
                else if (gameObject.tag == "YellowPanelTag")
                {
                    //PlayerStatusスクリプトのSetDamage関数にダメージ値を渡す
                    gameObject.GetComponent<PlayerStatus>().SetDamage(yellowPanelPw);

                    //yellowPanelを破棄
                    Destroy(gameObject);
                }
            }
        }
    }
}
