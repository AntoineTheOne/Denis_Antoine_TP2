using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanterArbre : MonoBehaviour
{
    [SerializeField] private GameObject arbre;
    [SerializeField] private InfosJoueur infosJoueur;
    [SerializeField] private GameObject anchor;
    public bool arbreRouge;
    public bool arbreJaune;
    public bool arbreBleu;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Player")) return;

        if (infosJoueur.TypeDeSacDansMain == "Jaune" && arbreJaune)
        {
            ActivationArbreJaune();
            infosJoueur.sacEnMain = false;
        }
        else if (infosJoueur.TypeDeSacDansMain == "Rouge" && arbreRouge)
        {
            ActivationArbreRouge();
            infosJoueur.sacEnMain = false;
        }
        else if (infosJoueur.TypeDeSacDansMain == "Bleu" && arbreBleu)
        {
            ActivationArbreBleu();
            infosJoueur.sacEnMain = false;
        }
    }

    private void ActivationArbreJaune()
    {
        if (infosJoueur.TypeDeSacDansMain == "Jaune")
        {
            infosJoueur.point += 5;
            arbre.SetActive(true);
            infosJoueur.TypeDeSacDansMain = "";
            DetruireEnfants(anchor);
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
            Destroy(enfant.gameObject);
        }
    }
}
