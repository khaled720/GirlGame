using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlMovement : MonoBehaviour
{   
public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (rb.position.y < -1f)
		{
			FindObjectOfType<GameManager>().EndGame();
		}
        
    }
}
