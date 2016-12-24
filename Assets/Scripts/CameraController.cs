using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public GameObject player;
	private Vector3 offset;
	// Use this for initialization
	void Start () {
					//transform will refer to this's position by default
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () { //lateUpdate is guaranteed to run after everything else
		//camera is moved into a new position relative to it.
		transform.position = player.transform.position + offset;
	}

}
