using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FermerAudioMixer : MonoBehaviour
{
    [SerializeField] Canvas canvas;

[SerializeField] private GameObject Personnage;

    private AudioSource audioSource;
private void Start(){
            audioSource = Personnage.GetComponent<AudioSource>();
        }


public void FermerAudio(){
    canvas.gameObject.SetActive(false);
    Cursor.lockState = CursorLockMode.None;
    audioSource.Play(0);
}

}
