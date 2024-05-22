using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlanterArbre : MonoBehaviour
{
    [SerializeField] private GameObject arbre;
    [SerializeField] private InfosJoueur infosJoueur;



private void OnTriggerEnter(Collider other)
    {
        if(!other.gameObject.CompareTag("Player")) return;

        if (infosJoueur.sacJaune)
        {
            ActivationArbreJaune();
        }
        else if (infosJoueur.sacRouge)
        {
            ActivationArbreRouge();
        }
        else if (infosJoueur.sacBleu)
        {
            ActivationArbreBleu();
        }

    }

    private void ActivationArbreJaune()
    {
        if (infosJoueur.sacJaune)
        {
            infosJoueur.point++;
            arbre.SetActive(true);

        }
    }
    private void ActivationArbreRouge()
    {
        if (infosJoueur.sacRouge)
        {
            infosJoueur.point++;
            arbre.SetActive(true);
        }
    }

    private void ActivationArbreBleu()
    {
        if (infosJoueur.sacBleu)
        {
            infosJoueur.point++;
            arbre.SetActive(true);
        }
    }
    






}
