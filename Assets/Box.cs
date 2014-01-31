using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour {
	
	void OnCollisionEnter2D(Collision2D col){
		GameObject.Destroy (gameObject);	
		} 

}
