using UnityEngine;
using UnityEngine.UIElements;

public class PriseSacDeGraine : MonoBehaviour
{
    [SerializeField] private InfosJoueur infosJoueur;
    public bool graineRouge;
    public bool graineJaune;
    public bool graineBleu;

    void Start()
    {
        infosJoueur.sacEnMain = false;
        infosJoueur.point = 0;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player") && infosJoueur.sacEnMain == false)
        {

            if (graineRouge)
            {
                infosJoueur.sacEnMain = true;
                transform.SetParent(other.gameObject.transform.Find("AncorSac"), false);
                transform.localPosition = new Vector3(0, 0, 0);
                infosJoueur.TypeDeSacDansMain = "Rouge";
                Debug.Log(infosJoueur.point);
            }
            else if (graineJaune)
            {
                infosJoueur.sacEnMain = true;
                transform.SetParent(other.gameObject.transform.Find("AncorSac"), false);
                transform.localPosition = new Vector3(0, 0, 0);
                infosJoueur.TypeDeSacDansMain = "Jaune";
                Debug.Log(infosJoueur.point);
            }
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
