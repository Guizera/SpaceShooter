using UnityEngine;
public class Nave_Inimigo: MonoBehaviour{
    public int vida;
    public float velocidade; 

    void Start() {
        gameObject.GetComponent<Rigidbody2D>().velocity = transform.up * velocidade;
    }
    void FixedUpdate() {
        if (transform.position.y < -5) {
            Destroy(gameObject);
        }    
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player"))  {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Tiro")) { 
            Destroy(other.gameObject);
    
            vida -= PlayerTiros.dano;
            if (vida <= 0) {
                Destroy(gameObject);
            }    
        }  
    }  
}