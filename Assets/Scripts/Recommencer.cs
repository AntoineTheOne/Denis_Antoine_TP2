using UnityEngine;
using UnityEngine.SceneManagement; // Permet de changer de scène

public class Recommencer : MonoBehaviour
{


    public void RecommencerJeu(){
        SceneManager.LoadScene("Acceuil"); // Recharge la scène d’accueil
    }


}
