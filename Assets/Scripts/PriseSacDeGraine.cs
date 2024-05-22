using UnityEngine;

public class PriseSacDeGraine : MonoBehaviour
{
    [SerializeField] private GameObject graineDansMain;
    [SerializeField] private InfosJoueur infosJoueur;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player" && gameObject.CompareTag("Jaune")))
        {


            graineDansMain.SetActive(true);
            Destroy(gameObject);
            infosJoueur.sacJaune = true;
            Debug.Log(infosJoueur.sacJaune);
        }
    }
}