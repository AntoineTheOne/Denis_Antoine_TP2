using UnityEngine;
using UnityEngine.SceneManagement;

public class EchecOuGagneChangementScene : MonoBehaviour
{
    [SerializeField] private InfosJoueur infosJoueur;
    


    void Update()
    {
        if(infosJoueur.nbrVie <= 0){

        SceneManager.LoadScene("SceneEchec");
        Cursor.lockState = CursorLockMode.Confined;
        }

        if(infosJoueur.point == 36){
        SceneManager.LoadScene("SceneReussi");
        Cursor.lockState = CursorLockMode.Confined;
        }



    }
}
