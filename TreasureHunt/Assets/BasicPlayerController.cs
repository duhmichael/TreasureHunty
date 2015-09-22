using UnityEngine;
using System.Collections;

public class BasicPlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public float moveSpeed = 15f;
	//public float turnSpeed = 5f;
	//don't even need it! put the moveSpeed outside of the (0f, 0f, 0f)

	// Update is called once per frame
	void Update () {
	//sample code block for each button
		if (Input.GetKey (KeyCode.W)){
			//forward
			//move current object, framerate independent
			transform.position += new Vector3(0f, 0f, 1f) * Time.deltaTime * moveSpeed;
			//rotate the current object to face the way it's moving
			transform.eulerAngles = new Vector3(0f, 0f, 0f);
		}

		if (Input.GetKey (KeyCode.A)){
			//left
			transform.position += new Vector3(-1f,0f,0f) * Time.deltaTime * moveSpeed;
			transform.eulerAngles = new Vector3 (0f, -90f, 0f);
		}

		if (Input.GetKey (KeyCode.S)){
			//back
			transform.position += new Vector3(0f,0f,-1f) * Time.deltaTime * moveSpeed;
			transform.eulerAngles = new Vector3 (0f, 180f, 0f);
		}

		if (Input.GetKey (KeyCode.D)){
			//right
			transform.position += new Vector3(1f,0f,0f) * Time.deltaTime * moveSpeed;
			transform.eulerAngles = new Vector3 (0f, 90f, 0f);
		}

		if (Input.GetKey (KeyCode.Q)){
			//up
			transform.position += new Vector3(0f,01,0f) * Time.deltaTime * moveSpeed;
			transform.eulerAngles = new Vector3 (0f, 0f, 0f);
		}

		if (Input.GetKey (KeyCode.E)){
			//down
			transform.position += new Vector3(0f,-1f,0f) * Time.deltaTime * moveSpeed;
			transform.eulerAngles = new Vector3 (0f, 0f, 0f);
		}
		//move Main Camera to player's position, PLUS an offset above it
		Camera.main.transform.position = transform.position+ new Vector3(0f, 5, -25f);




	}
}
