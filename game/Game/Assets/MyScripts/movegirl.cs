using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//  coded by khaled
public class movegirl : MonoBehaviour
{
  Rigidbody girl_rigidbody;
   public float moveX=0.7f;
  private float runspeed=4.8f;
    public Animator anim;
	public Transform Girlposition;
	//public LayerMask groundLayer;
	//public float redius =0.2f;
	public bool grounded;

      void Start()
     {      
	 girl_rigidbody = GetComponent <Rigidbody> ();
            anim = GetComponent <Animator> ();   
            anim.Play("RUN00_F 1",-1,0f);
	 } 

    
 
  void Update()
        {
  
	girl_rigidbody.transform.Translate(0,0,moveX);
	 if (Girlposition.position.y>0.6)grounded=false;else grounded =true;
//	grounded=Physics2D.OverlapCircle(checkposition.position,redius,groundLayer);
	if(Input.GetKeyDown(KeyCode.Space) && grounded){
            moveX = 0.4f;
	anim.Play("JUMP00",-1,0f);
	jump();
	
	  }
	 //////////////////////////////////////////////
	      if(Input.GetKey("f")){
	//anim.Play("RUN00_L 0",-1,0f);
	Left();
	
	  }
	  //////////////////////////////////////////////
	      if(Input.GetKey("h")){
 //anim.Play("ROUND_R 0",-1,0f);
	Right();
	
	  }












		  } 

 
 public void jump(){
 
 girl_rigidbody.velocity=runspeed*Vector2.up;


 }
 
  public void Left(){
 
 girl_rigidbody.transform.Translate(-0.2f,0,0);
 }
  public void Right(){
 
 girl_rigidbody.transform.Translate(0.2f,0,0);
 }
 

 
 
 }

