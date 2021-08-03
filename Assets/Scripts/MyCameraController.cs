using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour
{
    //タップ開始地点の座標
    private Vector3 touchStartPos;
    //タップ終了地点の座標
    private Vector3 touchEndPos;

    private float distance = 100;

    private float duration = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray,out hit, Mathf.Infinity))
        {
            if(tag == "MagentaPanelTag")
            {
                Flick();
            }
        }

        Debug.DrawRay(ray.origin, ray.direction * distance, Color.red, duration);
    }


    void Flick()
    {
        if (-1.0f <= transform.position.z && transform.position.z <= 5.0f)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                touchStartPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
            }
            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                touchEndPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
                GetDirection();
            }
        }
    }


    //座標の管理
    void GetDirection()
    {
        float directionX = touchEndPos.x - touchStartPos.x;
        float directionY = touchEndPos.y - touchStartPos.y;

        if (Mathf.Abs(directionX) < Mathf.Abs(directionY))
        {
            if (3 < directionY)
            {
                Destroy(this.gameObject);
                Debug.Log("フリック相殺");
            }
        }
    }
}
