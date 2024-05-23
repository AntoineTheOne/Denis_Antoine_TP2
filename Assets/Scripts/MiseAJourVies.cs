using UnityEngine;
using TMPro;

public class MiseAJourVies : MonoBehaviour
{
    [SerializeField] private InfosJoueur infosJoueur;
    [SerializeField] private TextMeshProUGUI vieText;

    void Start()
    {
        MettreAJourVies();
    }

    void Update()
    {
        MettreAJourVies();
    }

    private void MettreAJourVies()
    {
        vieText.text = "Vies : " + infosJoueur.nbrVie.ToString();
    }
}