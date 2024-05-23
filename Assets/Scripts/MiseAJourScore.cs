using UnityEngine;
using TMPro;

public class MiseAJourScore : MonoBehaviour
{
    [SerializeField] private InfosJoueur infosJoueur;
    [SerializeField] TextMeshProUGUI scoreText;

    void Start()
    {

        UpdateScore();
    }

    void Update()
    {

        UpdateScore();
    }

    private void UpdateScore()
    {

        scoreText.text = "Score : " + infosJoueur.point.ToString();
    }
}
