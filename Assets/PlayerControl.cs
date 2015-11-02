using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// FixedUpdate is called once per tick
	void FixedUpdate () {
		float h = Input.GetAxis ("Horizontal")/10;
		float v = Input.GetAxis ("Vertical")/10;
		transform.Translate(new Vector3 (h, v, 0));
	}
}
