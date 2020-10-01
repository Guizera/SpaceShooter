using UnityEngine; 
[System.Serializable]

public class LimiteTela{ 
     public float xMin, xMax, yMin, yMax; 
}

public class PlayerGerente : MonoBehaviour {
     public float velocidade;

     public LimiteTela limite;

   void FixedUpdate() { 
       float horizontal = Input.GetAxis("Horizontal");
       float vertical = Input.GetAxis("Vertical");

       Vector3 mover = new Vector3(horizontal, vertical, 0); 
        gameObject.GetComponent<Rigidbody2D>().velocity = mover * velocidade;
        gameObject.GetComponent<Rigidbody2D>().position = new Vector3 (
           Mathf.Clamp(gameObject.GetComponent<Rigidbody2D>().position.x,
           limite.xMin, limite.xMax),
           Mathf.Clamp(gameObject.GetComponent<Rigidbody2D>().position.y,
           limite.yMin, limite.yMax),   0 );
    } 
}