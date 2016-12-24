using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime); //multiply by change in time because this should be time dependent,
		//not frame dependent


	}
}
