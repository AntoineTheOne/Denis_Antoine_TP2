using UnityEngine;

public class PerdreVieEnCollision : MonoBehaviour
{
    [SerializeField] private InfosJoueur infosJoueur; 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            PerdreVie();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy")) 
        {
            PerdreVie();
        }
    }

    private void PerdreVie()
    {
        if (infosJoueur.nbrVie > 0)
        {
            infosJoueur.nbrVie--;
            Debug.Log("Vies restantes: " + infosJoueur.nbrVie);
        }

        if (infosJoueur.nbrVie <= 0)
        {
            
            Debug.Log("Le joueur est mort.");
        }
    }
}