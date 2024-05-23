using UnityEngine;
using UnityEngine.AI;

public class Ennemi : MonoBehaviour
{
    [SerializeField] private Transform player;
    private NavMeshAgent agent;

    [SerializeField] private int nombreDistance = 10;
    [SerializeField] private Transform positionDepart;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    { 
        if (Vector3.Distance(agent.transform.position, player.position) < nombreDistance){
            agent.SetDestination(player.position);
        }
        else{
            agent.SetDestination(positionDepart.position);
        }
    }
}