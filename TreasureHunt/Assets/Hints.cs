using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hints : MonoBehaviour {

	public Text textUI;
	public Transform goal;
	public Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (player.position.x < -20f) {

			textUI.text = "That ain't my mummy...what's that to the south?";
		}

		if (player.position.x < -100f) {
			textUI.text = "So much shade...you see something looming over the sands in the east";
		}
		if ( (goal.position - player.position).magnitude < 50f) {
			textUI.text = "What's that under the waves...?";
		}
		if ( (goal.position - player.position).magnitude < 150f) {
			textUI.text = "Just a little further...?";
		}
	}
}
