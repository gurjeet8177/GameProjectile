using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Rigidbody playerBox;

    
	void Start () {
          
        
        playerBox.AddForce(0, 1000, 500);
	}
	
	
	void Update () {
     
    }
}
