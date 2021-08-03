using UnityEngine;

public class ObjectGenerator : MonoBehaviour
{
    [SerializeField] GameObject m_spawnPrefab = default;
    [SerializeField] Transform[] m_spawnPoints = default;
    [SerializeField] float m_interval = 1f;
    float m_timer;

    void Update()
    {
        m_timer += Time.deltaTime;

        if (m_timer > m_interval)
        {
            m_timer = 0;
            Instantiate(m_spawnPrefab, m_spawnPoints[Random.Range(0, m_spawnPoints.Length)].position, Quaternion.identity);
        }
    }
}
