using UnityEngine;

public class Tiro : MonoBehaviour {

    public float velocidade; 

    void Start() {

     gameObject.GetComponent<Rigidbody2D>().velocity = transform.up * velocidade;    
   
    }    
}
