using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPanelDestroy : MonoBehaviour
{
    //CyanPanelPrefabを入れる
    public GameObject CyanPanelPrefab;

    //MagentaPanelPrefabを入れる
    public GameObject MagentaPanelPrefab;

    //YellowPanelPrefabを入れる
    public GameObject YellowPanelPrefab;

    //フリック開始地点の座標
    private Vector3 flickStartPos;
    //フリック終了地点の座標
    private Vector3 flickEndPos;

    //フリックを判定する時間のしきい値
    private float flickTime = 0.15f;

    //フリックを判定するローカルタイマー
    private float timer = 0.0f;

    //長押ししたのかを判断する
    private bool push = false;


    //CyanPanelをタップ相殺する{Event Trigger(click)}
    public void PanelOffset()
    {
        if (-1.0f <= transform.position.z && transform.position.z <= 5.0f)
        {
            Destroy(this.gameObject);
            Debug.Log("タップ相殺");
        }
    }


    //MagentaPanelをフリックする{Event Trigger(down)}
    public void FlickDown()
    {
        if (0.5f <= transform.position.z && transform.position.z <= 2.0f)
        {
            flickStartPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
            Debug.Log($"flickStartPos: {flickStartPos.ToString()}");

            Debug.Log("down");      
        }
    }


    //MagentaPanelをフリックする{Event Trigger(up)}
    public void FlickUp()
    {
        if (transform.position.z <= 3.5f)
        {
            flickEndPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
            Debug.Log($"flickEndPos: {flickEndPos.ToString()}");

            GetDirection();
            Debug.Log("up");        
        }
    }


    //YellowPanelを長押しする{Event Trigger(down)}
    public void PushDown()
    {
        push = true;
    }


    //YellowPanelを長押しする{Event Trigger(up)}
    public void PushUp()
    {
        push = false;
    }


    public void LongDestroy()
    {
        if (-1.0f <= transform.position.z && transform.position.z <= 5.0f)
        {
            Destroy(this.gameObject);
            Debug.Log("長押し相殺");
        }
    }


    //座標の管理
    void GetDirection()
    {
        float directionY = flickEndPos.y - flickStartPos.y;
        Debug.Log($"direction: {directionY.ToString()}");

        if (100 < directionY && timer < flickTime)
        {

            Destroy(this.gameObject);
            Debug.Log("フリック相殺");        
        }
    }
}
