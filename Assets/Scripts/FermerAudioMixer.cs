using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FermerAudioMixer : MonoBehaviour
{
[SerializeField] Canvas canvas; // Fenêtre du menu audio
[SerializeField] private GameObject Personnage; // Joueur
private AudioSource audioSource; // Source audio du joueur
private void Start(){
    audioSource = Personnage.GetComponent<AudioSource>(); // Récupère le son du joueur
 }


public void FermerAudio(){
    canvas.gameObject.SetActive(false); // Ferme le menu audio
    Cursor.lockState = CursorLockMode.None; // Libère le curseur
    audioSource.Play(0); // Joue un son de clic
}

}
