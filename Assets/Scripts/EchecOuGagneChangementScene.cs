using UnityEngine;
using UnityEngine.SceneManagement;

public class EchecOuGagneChangementScene : MonoBehaviour
{
    [SerializeField] private InfosJoueur infosJoueur; // Référence aux infos du joueur
    


    void Update()
    {
        if(infosJoueur.nbrVie <= 0){ // Si plus de vie

        SceneManager.LoadScene("SceneEchec"); // Va à la scène d’échec
        Cursor.lockState = CursorLockMode.Confined; // Libère le curseur dans l'écran du jeu
        }

        if(infosJoueur.point == 36){ // Si le joueur atteint le score parfait
        SceneManager.LoadScene("SceneReussi"); // Va à la scène de réussite
        Cursor.lockState = CursorLockMode.Confined;
        }



    }
}
