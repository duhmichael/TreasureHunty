using UnityEngine;
using System.Collections;

public class BasicPlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public float moveSpeed = 15f;
	public float turnSpeed = 5f;

	// Update is called once per frame
	void Update () {
	//sample code block for each button
		if (Input.GetKey (KeyCode.W)){
			//move current object, framerate independent
			transform.position += new Vector3(moveSpeed, 0f, 0f) * Time.deltaTime;
			//rotate the current object to face the way it's moving
			transform.eulerAngles = new Vector3(0f, turnSpeed, 0f);
		}

		//move Main Camera to player's position, PLUS an offset above it
		Camera.main.transform.position = transform.position
			+ new Vector3(0f, 5, -25f);




	}
}
