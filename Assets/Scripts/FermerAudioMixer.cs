using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FermerAudioMixer : MonoBehaviour
{
    [SerializeField] Canvas canvas;

public void FermerAudio(){
    canvas.gameObject.SetActive(false);
    Cursor.lockState = CursorLockMode.None;
}

}
