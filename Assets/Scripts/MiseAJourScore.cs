using UnityEngine;
using TMPro; // Nécessaire pour afficher du texte avec TextMeshPro

public class MiseAJourScore : MonoBehaviour
{
    [SerializeField] private InfosJoueur infosJoueur; // Référence au ScriptableObject contenant les infos du joueur
    [SerializeField] TextMeshProUGUI scoreText; // Texte UI affichant le score du joueur
    void Start()
    {
        UpdateScore(); // Appelle la fonction une première fois au démarrage
    }
    void Update()
    {
        UpdateScore(); // Met à jour le texte du score à chaque frame (temps réel)
    }
    private void UpdateScore()
    {
        scoreText.text = "Score : " + infosJoueur.point.ToString(); // Met à jour le texte avec le score du joueur
    }
}
