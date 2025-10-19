using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlanterArbre : MonoBehaviour
{
    [SerializeField] private GameObject arbre; // Objet arbre à activer
    [SerializeField] private InfosJoueur infosJoueur; // Données du joueur
    [SerializeField] private GameObject anchor; // Point d’ancrage pour supprimer les sacs
    public bool arbreRouge; // Si cet arbre est rouge
    public bool arbreJaune; // Si cet arbre est jaune
    public bool arbreBleu; // Si cet arbre est bleu
    [SerializeField] private GameObject Personnage; // Référence au joueur
    private AudioSource audioSource; // Pour jouer un son
    void Start(){
        audioSource = Personnage.GetComponent<AudioSource>(); // Récupère l’audio du joueur
    }
    private void OnTriggerEnter(Collider other)
    {   audioSource.Play(0); // Joue un son dès qu’on entre dans la zone
        if (!other.gameObject.CompareTag("Player")) return; // Ignore si ce n’est pas le joueur

         // Vérifie le type de sac et l’arbre correspondant
        if (infosJoueur.TypeDeSacDansMain == "Jaune" && arbreJaune)
        {
            ActivationArbreJaune();
            infosJoueur.sacEnMain = false;
        }
        else if (infosJoueur.TypeDeSacDansMain == "Rouge" && arbreRouge)
        {
            ActivationArbreRouge();
            audioSource.Play(0);
            infosJoueur.sacEnMain = false;
        }
        else if (infosJoueur.TypeDeSacDansMain == "Bleu" && arbreBleu)
        {
            ActivationArbreBleu();
            audioSource.Play(0);
            infosJoueur.sacEnMain = false;
        }
    }
    private void ActivationArbreJaune()
    {
        if (infosJoueur.TypeDeSacDansMain == "Jaune")
        {
            infosJoueur.point += 5; // Ajoute des points
            arbre.SetActive(true); // Fait apparaître l’arbre
            infosJoueur.TypeDeSacDansMain = ""; // Vide le type de sac
            DetruireEnfants(anchor); // Supprime les objets enfants
        }
    }
    private void ActivationArbreRouge()
    {
        if (infosJoueur.TypeDeSacDansMain == "Rouge")
        {
            infosJoueur.point += 1;
            arbre.SetActive(true);
            infosJoueur.TypeDeSacDansMain = "";
            DetruireEnfants(anchor);
        }
    }
    private void ActivationArbreBleu()
    {
        if (infosJoueur.TypeDeSacDansMain == "Bleu")
        {
            infosJoueur.point += 3;
            arbre.SetActive(true);
            infosJoueur.TypeDeSacDansMain = "";
            DetruireEnfants(anchor);
        }
    }
    private void DetruireEnfants(GameObject parent)
    {
        foreach (Transform enfant in parent.transform)
        {
            Destroy(enfant.gameObject); // Supprime tous les enfants du parent
        }
    }
}
