using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour 
  {
    private Vector2 initial;
    private Vector2 startpos;
    private Vector2 firepos1;
    private Vector2 firepos2;

    public GameObject Effect;
    public GameObject firework;
   void OnCollisionEnter2D(Collision2D col){
       if (col.gameObject.tag=="Goal"){
           startpos=transform.position;
           initial=transform.position;
            firepos1=transform.position;
            firepos2=transform.position;

           startpos.x=-.05f;
          startpos.y=2.79f;
           GameObject effect = Instantiate (Effect, startpos, transform.rotation);
                    //    Invoke("Restart", 3f);

            firepos1.y = 2.25f;
            firepos1.x = -7.25f;
         GameObject effect2 = Instantiate (firework, firepos1, transform.rotation);
                    // Invoke("Restart", 3f);

         firepos2.x=7.25f;
         firepos2.y=2.25f;
         GameObject effect3 = Instantiate (firework, firepos2, transform.rotation);


        //    Invoke("Restart", 2f);
       }
 

   }
    void Restart(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
    // Update is called once per fr
}
