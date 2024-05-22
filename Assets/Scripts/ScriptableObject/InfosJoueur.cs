using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[CreateAssetMenu(fileName = "InfosJouer", menuName = "InfosJoueur")]
public class InfosJoueur : ScriptableObject
{

    
    public string nomJoueur;
    public string nomVillage;

    public int point;
    public int nbrVie;

    public bool sacEnMain = false;



public string TypeDeSacDansMain;



}
