using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class changementUi : MonoBehaviour
{
    [SerializeField] private InfosJoueur infosJoueur; // Données du joueur
    [SerializeField] TextMeshProUGUI texteJoueur; // Texte affichant le nom du joueur
    [SerializeField] TextMeshProUGUI texteVillage; // Texte du village
    [SerializeField] TextMeshPro textePanneauVillage; // Texte sur le panneau du village
    void Start()
    {
        UpdateTexteJoeur(); // Met à jour le texte joueur
        UpdateTexteVillage(); // Met à jour le texte du village
    }

    // Update is called once per frame
    void UpdateTexteJoeur()
    {
        texteJoueur.text = infosJoueur.nomJoueur; // Affiche le nom du joueur
    }
    void UpdateTexteVillage()
    {
        texteVillage.text = infosJoueur.nomVillage; // Affiche le nom du village dans l’UI
        textePanneauVillage.text = infosJoueur.nomVillage; // Et sur le panneau du jeu

    }
}
