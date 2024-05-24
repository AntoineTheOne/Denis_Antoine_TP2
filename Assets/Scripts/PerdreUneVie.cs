using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerdreUneVie : MonoBehaviour
{



    [SerializeField] InfosJoueur infosJoueur;

    [SerializeField] private GameObject Personnage;

    private AudioSource audioSource;


        private void Start(){
            audioSource = Personnage.GetComponent<AudioSource>();
        }

   private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            PerdreVie();
        }
    }

    private void PerdreVie()
    {
        if (infosJoueur.nbrVie > 0)
        {
            infosJoueur.nbrVie--;
            audioSource.Play(0);
            
        }

        
    }





}


