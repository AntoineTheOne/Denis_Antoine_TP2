using UnityEngine;
using UnityEngine.AI;

public class Ennemi : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 zoneSize;

    private bool enPoursuite = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        CommencerErrance();
    }

    void Update()
    {
        if (!enPoursuite)
        {
            if (agent.remainingDistance < 0.5f)
            {
                ChoisirDestinationAleatoireDansZone();
            }
        }
        else
        {
            agent.SetDestination(player.position);
        }
    }

    void CommencerErrance()
    {
        ChoisirDestinationAleatoireDansZone();
    }

    void ChoisirDestinationAleatoireDansZone()
    {
        Vector3 randomDestination = transform.position + new Vector3(Random.Range(-zoneSize.x / 2f, zoneSize.x / 2f),
                                                                      0f,
                                                                      Random.Range(-zoneSize.z / 2f, zoneSize.z / 2f));
        agent.SetDestination(randomDestination);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("allo je suis rentré");
            enPoursuite = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enPoursuite = false;
            CommencerErrance();
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, zoneSize);
    }
}