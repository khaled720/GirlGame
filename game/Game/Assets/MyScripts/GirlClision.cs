using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlClision : MonoBehaviour
{ 
   public Animator anim;
 
  
  public void Start(){

  anim = GetComponent<Animator>();
    // Start is called before the first frame update
    }
	//public GirlMovement movement;     // A reference to our PlayerMovement script
        public movegirl MOVE_Girl;
	// This function runs when we hit another object.
	// We get information about the collision and call it "collisionInfo".
	void OnCollisionEnter (Collision collisionInfo)
	{
		// We check if the object we collided with has a tag called "Obstacle".
		if (collisionInfo.collider.tag == "Obstacle")
		{
			 MOVE_Girl.enabled = false;   // Disable the players movement.
		
			anim.Play("DAMAGED01",-1,0f);
		//	Manager.SetActive(false);
			//GetComponent("Movegirl").enable =false;
			FindObjectOfType<GameManager>().EndGame();
		}
	}}
