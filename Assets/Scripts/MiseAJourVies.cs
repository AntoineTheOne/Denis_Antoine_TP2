using UnityEngine;
using TMPro; // Nécessaire pour TextMeshPro

public class MiseAJourVies : MonoBehaviour
{
    [SerializeField] private InfosJoueur infosJoueur; // Référence au ScriptableObject InfosJoueur
    [SerializeField] private TextMeshProUGUI vieText; // Texte UI pour afficher les vies
    void Start()
    {
        infosJoueur.nbrVie = 4; // Donne 4 vies au début du jeu
        MettreAJourVies(); // Affiche les vies dès le départ
    }
    void Update()
    {
        MettreAJourVies(); // Met à jour l’affichage à chaque frame
    }
    private void MettreAJourVies()
    { 
        vieText.text = "Vies : " + infosJoueur.nbrVie.ToString(); // Met à jour le texte UI
    }
}