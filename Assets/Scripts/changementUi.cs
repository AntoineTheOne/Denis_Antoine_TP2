using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class changementUi : MonoBehaviour
{
    [SerializeField] private InfosJoueur infosJoueur;
    [SerializeField] TextMeshProUGUI texteJoueur;
    [SerializeField] TextMeshProUGUI texteVillage;
    [SerializeField] TextMeshPro textePanneauVillage;
    void Start()
    {
        UpdateTexteJoeur();
        UpdateTexteVillage();
    }

    // Update is called once per frame
    void UpdateTexteJoeur()
    {
        texteJoueur.text = infosJoueur.nomJoueur;
    }
    void UpdateTexteVillage()
    {
        texteVillage.text = infosJoueur.nomVillage;
        textePanneauVillage.text = infosJoueur.nomVillage;

    }
}
