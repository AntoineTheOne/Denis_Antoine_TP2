using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlanterArbre : MonoBehaviour
{
    [SerializeField] private GameObject arbre;
    [SerializeField] private InfosJoueur infosJoueur;
    [SerializeField] private GameObject anchor;



private void OnTriggerEnter(Collider other)
    {
        if(!other.gameObject.CompareTag("Player")) return;

        if (infosJoueur.sacJaune && infosJoueur.sacRouge == false && infosJoueur.sacBleu == false)
        {
            ActivationArbreJaune();
            infosJoueur.sacEnMain = false;
        }
        else if (infosJoueur.sacJaune == false && infosJoueur.sacRouge && infosJoueur.sacBleu == false)
        {
            ActivationArbreRouge();
            infosJoueur.sacEnMain = false;
        }
        else if (infosJoueur.sacJaune == false && infosJoueur.sacRouge == false && infosJoueur.sacBleu)
        {
            ActivationArbreBleu();
            infosJoueur.sacEnMain = false;
        }

    }

    private void ActivationArbreJaune()
    {
        if (infosJoueur.sacJaune)
        {
            infosJoueur.point += 5;
            arbre.SetActive(true);
            infosJoueur.sacJaune = false;
            Destroy(anchor);
        }
    }
    private void ActivationArbreRouge()
    {
        if (infosJoueur.sacRouge)
        {
            infosJoueur.point += 1;
            arbre.SetActive(true);
            infosJoueur.sacRouge = false;
            Destroy(anchor);
        }
    }

    private void ActivationArbreBleu()
    {
        if (infosJoueur.sacBleu)
        {
            infosJoueur.point += 3;
            arbre.SetActive(true);
            infosJoueur.sacBleu = false;
            Destroy(anchor);
        }
    }
    






}
