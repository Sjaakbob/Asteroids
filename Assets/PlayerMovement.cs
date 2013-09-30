using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	public float thrusterSpeed;
	public float rotationSpeed;
	
	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void FixedUpdate(){
		float movement = Input.GetAxis("Vertical")* thrusterSpeed * Time.deltaTime;
		float rotation = Input.GetAxis("Horizontal")* rotationSpeed * Time.deltaTime;
		
		rigidbody.AddRelativeForce(0, 0, movement);
		transform.Rotate(0, rotation, 0);
		
		}
	
		
}
