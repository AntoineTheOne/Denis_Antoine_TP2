using UnityEngine;

[CreateAssetMenu(fileName = "DonneesScore", menuName = "ScriptableObjects/DonneesScore")]
public class DonneesScore : ScriptableObject
{
    private int score;

    public int Score
    {
        get { return score; }
        set { score = value; }
    }

    public void IncrementerScore(int montant)
    {
        score += montant;
    }

    public void ReinitialiserScore()
    {
        score = 0;
    }
}