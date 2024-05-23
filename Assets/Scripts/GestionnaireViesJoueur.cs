using UnityEngine;

public class GestionViesJoueur : MonoBehaviour
{
    [SerializeField] private InfosJoueur infosJoueur;


void Start(){
    infosJoueur.nbrVie = 4;
}


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ennemi"))
        {
            PerdreVie();
            Debug.Log("merde");
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