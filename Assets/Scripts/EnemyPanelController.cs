using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPanelController : MonoBehaviour
{
    //落下する速さ
    private float fallSpeed = 10.0f;

    //消滅位置
    private float deadLine = -2.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }


    void FixedUpdate()
    {
        //パネルを落下させる
        transform.Translate(0, 0, this.fallSpeed * Time.deltaTime);

        //画面外に出たら破棄する
        if (transform.position.z < this.deadLine)
        {
            Destroy(gameObject);
        }
    }
}
