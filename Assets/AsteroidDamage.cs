using UnityEngine;
using System.Collections;

public class AsteroidDamage : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.name == "Player")
		{
			Application.LoadLevel("Scene1");
			//Debug.Log("Lose one life");
		}
		if(col.gameObject.name == "bullet(Clone)")
		{
			Destroy(col.gameObject);
			Destroy(gameObject);
		}
	}	
}
