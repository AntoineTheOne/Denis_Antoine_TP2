using UnityEngine;
using UnityEngine.Audio;

public class GestionnaireAudio : MonoBehaviour
{

    [SerializeField] private AudioMixer audioMixer;



    public void AjusteVolumeMusique(float volume){
        audioMixer.SetFloat("VolumeMusique", volume);
    }
    public void AjusteVolumeEffets(float volume){
        audioMixer.SetFloat("VolumeEffets", volume);
    }


}
