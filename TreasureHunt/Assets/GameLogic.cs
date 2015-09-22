using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {

	public Transform player;
	public Transform goal; 
	public Text textUI;
	public float distance = 10f; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		distance = Vector3.Distance (player.position, transform.position); 

		if( Input.GetKeyDown (KeyCode.Space) && (distance < 6f)) {
			textUI.text = "You've found your treasure!";
		}

	}
}
