using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionnaireAccueil : MonoBehaviour
{
[SerializeField] private InfosJoueur infosJoueur; // Données du joueur




private void Start(){
    infosJoueur.nomJoueur = ""; // Réinitialise le nom
    infosJoueur.nomVillage = ""; // Réinitialise le village
}
   public void ChangementNomJoueur(string nomJoueurTexte){
    infosJoueur.nomJoueur = nomJoueurTexte; // Enregistre le nom entré
    Debug.Log(infosJoueur.nomJoueur);
   }
   public void ChangementNomVillage(string nomVillageTexte){
    infosJoueur.nomVillage = nomVillageTexte; // Enregistre le village entré
    Debug.Log(infosJoueur.nomVillage);
   }


   public void VerifChangmenentScene(){
    // Si le joueur et le village ont un nom
    if(infosJoueur.nomJoueur != "" && infosJoueur.nomVillage != ""){
        SceneManager.LoadScene("ScenePrincipal"); // Charge la scène principale
    }
   }
}
