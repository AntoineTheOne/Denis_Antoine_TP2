using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionnaireAccueil : MonoBehaviour
{
[SerializeField] private InfosJoueur infosJoueur;

   public void ChangementNom(string nomJoueur){
    infosJoueur.nomJoueur = nomJoueur;
    Debug.Log(infosJoueur.nomJoueur);
   }
   public void ChangementNomVillage(string nomVillage){
    infosJoueur.nomVillage = nomVillage;
    Debug.Log(infosJoueur.nomVillage);
   }


   public void VerifChangmenentScene(){
    if(infosJoueur.nomJoueur != "" && infosJoueur.nomVillage != ""){
        ChangementScene("Village");
    }
   }


    public void ChangementScene(string _nomScene){
        SceneManager.LoadScene(_nomScene);
    }

   
}
