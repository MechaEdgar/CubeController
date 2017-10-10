using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 3.5f;
	public float rotatingSpeed = 40f;
	public float jumpingForce = 10f;

	private bool canJump = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	//right movement
	void Update () {
		if (Input.GetKey("right")){
			//Logic to move to the right
			//transform.position += Vector3.right* speed * Time.deltaTime;

			//Logic to Rotate
			transform.RotateAround(transform.position, Vector3.up, rotatingSpeed * Time.deltaTime);

		}

	//Left movement
		if(Input.GetKey("left")){
			//Logic to move to the left
			//transform.position += Vector3.left * speed * Time.deltaTime;

			//Logic to rotate to the left
			transform.RotateAround(transform.position, Vector3.up, -rotatingSpeed * Time.deltaTime);
		}

	// Up movement
		if(Input.GetKey("up")){
			transform.position += Vector3.forward * speed * Time.deltaTime;
		}

	//UpMovement
		if(Input.GetKeyDown("space") && canJump){
			GetComponent<Rigidbody> ().AddForce (0,jumpingForce,0);
			canJump = false;
		}
	}
	void OnCollisionEnter (Collision collision){
		if (collision.transform.name == "Plane"){
			Debug.Log ("Hit the floor!");
			canJump = true;
		}
	}
	}

