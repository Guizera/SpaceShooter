using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour {
    public float velocidade;
    void Start() {

        gameObject.GetComponent<Rigidbody2D>().velocity = -transform.up * velocidade;    
    }

    void FixedUpdate() {

        if (transform.position.y < -5) {

          Destroy(gameObject); 
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
     if (other.tag == "Player")  {
            PlayerTiros.dano = 10;
            Destroy(gameObject);
       }    
    }  
}
