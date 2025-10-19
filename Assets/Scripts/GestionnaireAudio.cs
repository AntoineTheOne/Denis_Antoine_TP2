using UnityEngine;
using UnityEngine.Audio; // Nécessaire pour modifier le volume

public class GestionnaireAudio : MonoBehaviour
{

    [SerializeField] private AudioMixer audioMixer; // Référence au mixeur audio



    public void AjusteVolumeMusique(float volume){
        audioMixer.SetFloat("VolumeMusique", volume); // Change le volume de la musique
    }
    public void AjusteVolumeEffets(float volume){
        audioMixer.SetFloat("VolumeEffets", volume); // Change le volume des effets sonores
    }


}
