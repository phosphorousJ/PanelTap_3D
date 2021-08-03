using UnityEngine;

public class RayCasterController : MonoBehaviour
{
    LineRenderer m_line = default;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                GameObject go = hit.collider.gameObject;

                if (go.tag == "PanelTag")
                {
                    DrawLine(go.transform.position);
                    PanelController p = go.GetComponent<PanelController>();
                    p.Attack();
                }
            }
        }

        if (Input.GetButtonUp("Fire1"))
        {
            DrawLine(this.transform.position);
        }
    }

    void Start()
    {
        m_line = GetComponent<LineRenderer>();
    }

    void DrawLine(Vector3 targetPosition)
    {
        Vector3 origin = this.transform.position;
        m_line.SetPosition(0, origin);
        m_line.SetPosition(1, targetPosition);
    }
}
