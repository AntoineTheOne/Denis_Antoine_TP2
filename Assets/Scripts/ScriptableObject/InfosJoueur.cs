using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// Crée un objet ScriptableObject accessible depuis le menu Assets
[CreateAssetMenu(fileName = "InfosJouer", menuName = "InfosJoueur")]
public class InfosJoueur : ScriptableObject
{

    
    public string nomJoueur; // Nom du joueur
    public string nomVillage; // Nom du village choisi

    public int point; // Score du joueur
    public int nbrVie; // Nombre de vies restantes

    public bool sacEnMain = false; // Si le joueur transporte un sac



public string TypeDeSacDansMain; // Type de sac porté (Rouge, Jaune ou Bleu)



}
