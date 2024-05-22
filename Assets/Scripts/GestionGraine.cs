using UnityEngine;
using UnityEngine.Events;

public class GestionGraine : MonoBehaviour
{
    [SerializeField] private string typeGraine; 
    public UnityEvent<string> onGraineRamasse; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onGraineRamasse.Invoke(typeGraine); 
            Destroy(gameObject); 
        }
    }
}