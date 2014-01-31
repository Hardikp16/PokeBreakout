using UnityEngine;
using System.Collections;



public class BallBehavior : MonoBehaviour {
	public float speed = 10;
	// Use this for initialization
	void Start () {

		rigidbody2D.velocity = new Vector2 (0, 10);
	}
	
	// Update is called once per frame
	void Update () {
		if (rigidbody2D.velocity.magnitude > speed) {
				rigidbody2D.velocity = rigidbody2D.velocity.normalized * speed;
			}


	}


}
