using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapPositionController : MonoBehaviour
{
    //BluePanelPrefabを入れる
    public GameObject BluePanelPrefab;

    //RedPanelPrefabを入れる
    public GameObject RedPanelPrefab;

    //GreenPanelPrefab1を入れる
    public GameObject GreenPanelPrefab1;

    //GreenPanelPrefab2を入れる
    public GameObject GreenPanelPrefab2;

    //GreenPanelPrefab3を入れる
    public GameObject GreenPanelPrefab3;

    //GreenPanelPrefab4を入れる
    public GameObject GreenPanelPrefab4;

    //タップ開始地点の座標
    private Vector3 flickStartPos;
    //タップ終了地点の座標
    private Vector3 flickEndPos;

    //フリックを判定する時間のしきい値
    private float flickTime = 0.15f;

    //フリックを判定するローカルタイマー
    private float timer = 0f;

    //長押しを開始したローカルタイマー
    private float startTimer;

    //長押しを終了したローカルタイマー
    private float endTimer;

    //長押しされた時間
    private float timeLong;

    //スタート地点
    private float startPosZ = 2.4f;
    private float startPosY = -2.36f;

    
    //RedPanelをフリック生成する{Event Trigger(down)}
    public void FlickDown()
    {
        
            if (transform.position.z <= 0.4f)
            {
                flickStartPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
                Debug.Log($"flickStartPos1: {flickStartPos.ToString()}");

                Debug.Log("down");
            }
        
    }


    //RedPanelをフリック生成する{Event Trigger(up)}
    public void FlickUp()
    {
        if (transform.position.z <= 3.5f)
        {
            flickEndPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
            Debug.Log($"flickEndPos1: {flickEndPos.ToString()}");

            GetDirection();
            Debug.Log("up");        
        }
    }


    //GreenPanelを長押し生成する{Event Trigger(down)}
    public void PushDown()
    {
        startTimer = Time.time;
    }


    //GreenPanelを長押し生成する{Event Trigger(up)}
    public void PushUp()
    {
        endTimer = Time.time;

        timeLong = endTimer - startTimer;
        Debug.Log($"{timeLong.ToString()}秒");

        LongGen();
    }


    //BluePanelおよびGreenPanelの生成条件
    void LongGen()
    {
        if (timeLong <= 0.1f)
        {
            GameObject blue = Instantiate(BluePanelPrefab);
            blue.transform.position = new Vector3(transform.position.x, startPosY, startPosZ);
        }
        else if (1.0f < timeLong && timeLong <= 2.0f)
        {
            GameObject green = Instantiate(GreenPanelPrefab1);
            green.transform.position = new Vector3(transform.position.x, startPosY, startPosZ);
        }
        else if (2.0f < timeLong && timeLong <= 3.0f)
        {
            GameObject green = Instantiate(GreenPanelPrefab2);
            green.transform.position = new Vector3(transform.position.x, startPosY, startPosZ);
        }
        else if (3.0f < timeLong && timeLong <= 4.0f)
        {
            GameObject green = Instantiate(GreenPanelPrefab3);
            green.transform.position = new Vector3(transform.position.x, startPosY, startPosZ);
        }
        else if (4.0f < timeLong)
        {
            GameObject green = Instantiate(GreenPanelPrefab4);
            green.transform.position = new Vector3(transform.position.x, startPosY, startPosZ);
        }
    }


    //座標の管理
    void GetDirection()
    {
        float directionY = flickEndPos.y - flickStartPos.y;
        Debug.Log($"direction1: {directionY.ToString()}");

        if (100 < directionY && timer < flickTime)
        {
            GameObject red = Instantiate(RedPanelPrefab);
            red.transform.position = new Vector3(transform.position.x, startPosY, startPosZ);       
        }
    }
}
