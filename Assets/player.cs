using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    private Vector2 startpos;
    public GameObject Effect;
    public GameObject wsplash;
    public AudioSource love;
    public AudioSource lose;

   void OnCollisionEnter2D(Collision2D col){
       if (col.gameObject.tag=="Goal"){
           startpos=transform.position;
               startpos.y+=1.3f;
            love.Play();
           GameObject effect = Instantiate (Effect, startpos, transform.rotation);
           Invoke("Restart", 3f);
       }
       if (col.gameObject.tag=="water"){
           lose.Play();
            GameObject splash = Instantiate (wsplash, col.transform.position, col.transform.rotation);
            Invoke("Restart", 3f);

       }

   }
   void Restart(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
}
