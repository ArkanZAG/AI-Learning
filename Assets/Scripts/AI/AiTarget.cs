using UnityEngine;
using UnityEngine.AI;

public class AiTarget : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float attackDistance;
    [SerializeField] private NavMeshAgent m_Agent;
    [SerializeField] private float m_Distance;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_Distance = Vector3.Distance(m_Agent.transform.position, target.position);
        if (m_Distance < attackDistance)
        {
            m_Agent.isStopped = true;
        }
        else
        {
            m_Agent.isStopped = false;
            m_Agent.destination = target.position;
        }
        
    }
}
