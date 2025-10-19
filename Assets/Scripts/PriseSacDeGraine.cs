using UnityEngine;
using UnityEngine.UIElements;

public class PriseSacDeGraine : MonoBehaviour
{
    [SerializeField] private InfosJoueur infosJoueur; // Référence au ScriptableObject contenant les infos du joueur
    public bool graineRouge; // Indique si ce sac est rouge
    public bool graineJaune; // Indique si ce sac est Jaune
    public bool graineBleu; // Indique si ce sac est Bleu

    void Start()
    {
        infosJoueur.sacEnMain = false; // Le joueur commence sans sac
        infosJoueur.point = 0; // Le score de la partie est réinitialisé
    }
    private void OnTriggerEnter(Collider other)
    {
        // Si le joueur entre en contact et n’a pas déjà un sac
        if (other.gameObject.CompareTag("Player") && infosJoueur.sacEnMain == false)
        {
            // Si c’est un sac rouge
            if (graineRouge)
            {
                infosJoueur.sacEnMain = true; // Le joueur porte un sac
                transform.SetParent(other.gameObject.transform.Find("AncorSac"), false); // Attache le sac à un point du joueur
                transform.localPosition = new Vector3(0, 0, 0); // Centre le sac sur le point d’ancrage
                infosJoueur.TypeDeSacDansMain = "Rouge"; // Enregistre le type de sac
                Debug.Log(infosJoueur.point);
            }
            // Si c’est un sac jaune
            else if (graineJaune)
            {
                infosJoueur.sacEnMain = true;
                transform.SetParent(other.gameObject.transform.Find("AncorSac"), false);
                transform.localPosition = new Vector3(0, 0, 0);
                infosJoueur.TypeDeSacDansMain = "Jaune";
                Debug.Log(infosJoueur.point);
            }
            // Si c’est un sac bleu
            else if (graineBleu)
            {
                infosJoueur.sacEnMain = true;
                transform.SetParent(other.gameObject.transform.Find("AncorSac"), false);
                transform.localPosition = new Vector3(0, 0, 0);
                infosJoueur.TypeDeSacDansMain = "Bleu";
                Debug.Log(infosJoueur.point);
            }
        }
    }
}
