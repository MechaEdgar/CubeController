using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 3.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	//right movement
	void Update () {
		if (Input.GetKey("right")){
			transform.position += Vector3.right* speed * Time.deltaTime;
		}

	//Left movement
		if(Input.GetKey("left")){
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
	}		
	}

