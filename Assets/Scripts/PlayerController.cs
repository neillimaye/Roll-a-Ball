using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb;
	public float speed; //this is so that in the unity editor we can edit this value without having to go into code
	private int count;
	public Text countText; //reference to the CountText component
	public Text winText;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		winText.text = " ";
	}
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);
		rb.AddForce (movement*speed);
	}
						//reference to what we touched
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag("Pick Up")){
			other.gameObject.SetActive(false);
			count++;
			SetCountText ();
		}
	}
	void SetCountText(){
		countText.text = "Count: " + count.ToString ();
		if (count == 12) {
			winText.text = "You Win!";
		}
	}
		
}
