using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScenes : MonoBehaviour
{
  public void ChangeScenes (string scenename){
  
  
  Application.LoadLevel(scenename);
  
  }
   public void Exit(){
  
  
 // Application.Quit();
  Application.LoadLevel("GameMenu");
  
  }





}
