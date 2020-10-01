using UnityEngine;

public class DestroiTiro : MonoBehaviour{

    void FixedUpdate(){

        if (transform.position.y > 9) {
          
           Destroy(gameObject);
        }    
    }  
}

