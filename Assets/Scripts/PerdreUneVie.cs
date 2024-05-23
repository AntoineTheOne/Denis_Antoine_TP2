using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerdreUneVie : MonoBehaviour
{



    [SerializeField] InfosJoueur infosJoueur;


   private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            PerdreVie();
            Debug.Log("allo");
            
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


