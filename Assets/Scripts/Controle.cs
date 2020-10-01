using System.Collections;
using UnityEngine;
public class Controle : MonoBehaviour {
   public GameObject inimigos1;
   public GameObject inimigos2;
   public GameObject inimigos3;
   private GameObject inimigos;
   public Vector3 posInimigos;
   public int waveCount;
   public float startWave;
   public float esperaWave;
   public float tempoNaves;
   public float tempoWave;
   public GameObject powerUps;
   public Vector3 posPowerUps;
   private int proxInimigo = 0;
   void Start() {
    StartCoroutine(CriaInimigos ()); 
   }
    IEnumerator CriaInimigos() {
       yield return new WaitForSeconds(startWave); 
       while(true){ 
           if (proxInimigo>=0 && proxInimigo <=6) { inimigos = inimigos1; }
           if (proxInimigo >= 6 && proxInimigo <= 10) { inimigos = inimigos2; }
           if (proxInimigo >= 10 && proxInimigo <= 15) { inimigos = inimigos3; }
           if (proxInimigo <= 15) {
                for (int i = 0; i < waveCount; i++) { 
                    Vector3 spawInimigos = new Vector3(Random.Range(-posInimigos.x, posInimigos.x), posInimigos.y, inimigos.transform.position.z);
                    Instantiate(inimigos, spawInimigos, inimigos.transform.rotation);
                    yield return new WaitForSeconds(tempoWave); 
                } 
            }
            yield return new WaitForSeconds(esperaWave);
            Vector3 spawPopwerUp = new Vector3(Random.Range(-posPowerUps.x, posPowerUps.x), posPowerUps.y, posPowerUps.z);
            Instantiate(powerUps, spawPopwerUp, powerUps.transform.rotation);
            proxInimigo++; 
        }  
    } 
}
