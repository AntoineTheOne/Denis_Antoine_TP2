using UnityEngine;
using UnityEngine.AI; // Pour le pathfinding

public class Ennemi : MonoBehaviour
{
    [SerializeField] private Transform player; // Cible du joueur
    private NavMeshAgent agent; // Agent de navigation

    [SerializeField] private int nombreDistance = 10; // Distance d’activation
    [SerializeField] private Transform positionDepart; // Position de retour


    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); // Récupère le composant NavMeshAgent
    }
    void Update()
    {   // Si le joueur est proche, l’ennemi le poursuit
        if (Vector3.Distance(agent.transform.position, player.position) < nombreDistance)
        {
            agent.SetDestination(player.position);
        }
        // Sinon, il retourne à sa position de départ
        else
        {
            agent.SetDestination(positionDepart.position);
        }
    }
}