using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameplay : MonoBehaviour
{
  public int index;
   public void Start(){
       Time.timeScale=0;
   }
   public void Play(){
       Time.timeScale=1;
   }
   public void Replay(){
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       Time.timeScale=1;
   }
   public void Next(){
     SceneManager.LoadScene(index);
   }
   public void Exit(){
     Application.Quit();
   }
}
