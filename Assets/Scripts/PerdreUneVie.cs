using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerdreUneVie : MonoBehaviour
{
    [SerializeField] InfosJoueur infosJoueur; // Référence au ScriptableObject
    [SerializeField] private GameObject Personnage; // Référence au joueur
    private AudioSource audioSource; // Pour jouer un son


        private void Start(){
            audioSource = Personnage.GetComponent<AudioSource>(); // Récupère le composant AudioSource du joueur
        }
   private void OnTriggerEnter(Collider other) 
    {

        if (other.gameObject.CompareTag("Player")) // Si le joueur entre en collision
        {
            PerdreVie(); // Appelle la fonction pour perdre une vie
        }
    }
    private void PerdreVie() // Si le joueur a encore des vies
    {
        if (infosJoueur.nbrVie > 0)
        {
            infosJoueur.nbrVie--; // Retire une vie
            audioSource.Play(0);  // Joue le son associé
        } 
    }
}


