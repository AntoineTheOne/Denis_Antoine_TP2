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
                
                //Vector3 positionSac = new Vector3(0f, 0f, 0f);
               //transform.SetPositionAndRotation( positionSac, other.gameObject.transform.rotation);
                transform.localPosition = new Vector3(0,0,0);
                infosJoueur.sacJaune = true;
            }
        

    }
}


// && gameObject.CompareTag("Jaune")