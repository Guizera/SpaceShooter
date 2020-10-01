using UnityEngine;
public class Parallax : MonoBehaviour {
    public float velocidade;
    public GameObject fimTela;
    public GameObject gerencia_Inicio; 
    void FixedUpdate() {
        Vector3 pos = new Vector3(transform.position.x, transform.position.y - velocidade, transform.position.z);
        transform.position = pos;
        if (transform.position.y < fimTela.transform.position.y) { 
            Vector3 fim = gerencia_Inicio.transform.position; 
            transform.position = fim;
        }   
   }  
}