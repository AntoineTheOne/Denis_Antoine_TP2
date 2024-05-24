using UnityEngine;
using UnityEngine.SceneManagement;

public class EchecOuGagneChangementScene : MonoBehaviour
{
    [SerializeField] private InfosJoueur infosJoueur;
    


    void Update()
    {
        if(infosJoueur.nbrVie <= 0){

        SceneManager.LoadScene("SceneEchec");
        }

        if(infosJoueur.point == 36){
        SceneManager.LoadScene("SceneReussi");
        }



    }
}
