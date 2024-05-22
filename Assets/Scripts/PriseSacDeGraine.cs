using UnityEngine;
using UnityEngine.UIElements;

public class PriseSacDeGraine : MonoBehaviour
{
    [SerializeField] private GameObject graineDansMain;
    [SerializeField] private InfosJoueur infosJoueur;

    

void Start(){
    infosJoueur.sacEnMain = false;
}

    private void OnTriggerEnter(Collider other)
    {   
       
            if (other.gameObject.CompareTag("Player") && infosJoueur.sacEnMain == false)
            {
                infosJoueur.sacEnMain = true;
                transform.SetParent(other.gameObject.transform.Find("AncorSac"), false); 
                transform.localPosition = new Vector3(0,0,0);
                infosJoueur.sacJaune = true;
                Debug.Log(infosJoueur.point);
            }
        

    }
}


// && gameObject.CompareTag("Jaune")