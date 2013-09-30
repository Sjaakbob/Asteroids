using UnityEngine;
using System.Collections;

public class ShootBullet : MonoBehaviour {
	
	public Rigidbody bullet;

	bool fire = false;	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		
	 if(Input.GetAxis("Fire1") == 1 ){
			if(fire == false){
				fire = true;
				Rigidbody clone;
            	clone = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
            	clone.velocity = transform.TransformDirection(Vector3.forward * 10);
			}
		}
			else {fire = false;}
			
			//if(Input.GetAxis("Fire1") == 0){fire = false;}
	
	}	
	
	
}
