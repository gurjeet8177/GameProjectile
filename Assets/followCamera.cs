using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour {


    public Transform PlayerValues;
    public Vector3 offset;

	
	
	// Update is called once per frame
	void Update () {
        transform.position = PlayerValues.position + offset;
	}
}
