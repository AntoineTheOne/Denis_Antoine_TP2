using UnityEngine;

public class PriseSacDeGraine : MonoBehaviour
{
    [SerializeField] private GameObject graineDansMain;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            graineDansMain.SetActive(true);
            Destroy(gameObject);
        }
    }
}