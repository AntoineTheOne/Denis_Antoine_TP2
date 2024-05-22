using UnityEngine;

[CreateAssetMenu(fileName = "Arbre de couleur ", menuName = "Type d'arbre")]
public class Arbre : ScriptableObject
{
    public string nom;
    public string couleurArbre;
    public int pointsGagnes;
}