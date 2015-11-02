using UnityEngine;
using System.Collections;

public class Bludger : MonoBehaviour {
	public GameObject Player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 atPlayer = Vector2.MoveTowards(new Vector2(0,0),Player.transform.position- transform.position,1)*42;
		Debug.Log (atPlayer);
		GetComponent<Rigidbody2D>().AddForce(atPlayer);
	}
}
