using UnityEngine;

public class PanelController : MonoBehaviour
{
    bool m_vulnerable = false;

    void Update()
    {
        if (this.transform.position.z < -10)
        {
            Destroy(this.gameObject);
        }
    }

    public void Attack()
    {
        if (m_vulnerable)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BlueRibbonTag")
        {
            m_vulnerable = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "BlueRibbonTag")
        {
            m_vulnerable = false;
        }
    }
}
