using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionnaireAccueil : MonoBehaviour
{
[SerializeField] private InfosJoueur infosJoueur;




private void Start(){
    infosJoueur.nomJoueur = "";
    infosJoueur.nomVillage = "";
}
   public void ChangementNomJoueur(string nomJoueurTexte){
    infosJoueur.nomJoueur = nomJoueurTexte;
    Debug.Log(infosJoueur.nomJoueur);
   }
   public void ChangementNomVillage(string nomVillageTexte){
    infosJoueur.nomVillage = nomVillageTexte;
    Debug.Log(infosJoueur.nomVillage);
   }


   public void VerifChangmenentScene(){
    if(infosJoueur.nomJoueur != "" && infosJoueur.nomVillage != ""){
        SceneManager.LoadScene("village");
    }
   }
}
