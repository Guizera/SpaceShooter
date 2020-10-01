using UnityEngine;

public class PlayerTiros : MonoBehaviour{

     public GameObject shot;
     public Transform shotSpaw;
     public float tempo_Entre_Tiros;
     private float proximoTiro;
     public int tiroDano;
     public static int dano = 5;
     private float tempoPowerUp; 
     private bool timesUp = false;

     void Update() {

        if (Time.time > proximoTiro) {
        proximoTiro = Time.time + tempo_Entre_Tiros;
        Instantiate(shot, shotSpaw.position, shotSpaw.rotation);
        }
        tiroDano  = dano;     
        if (dano > 5 && !timesUp) {
            tempoPowerUp = Time.time + 30;
            timesUp = true; 
       }
        if (Time.time > tempoPowerUp) { 
            timesUp = false;
            dano = 5;        
        }   
    }   
}