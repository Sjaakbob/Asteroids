using UnityEngine;
using System.Collections;

public class AsteroidSpawn : MonoBehaviour {
		public Rigidbody asteroid;
	
 private float spawnAsteroid = 10;
 
 void Start () {
 
  for(int i = 0; i < 3; i++)
    {
      Vector3 astPos = new Vector3(Random.Range(-10,10),0,Random.Range(-5,5));
      GameObject ast = Instantiate(Resources.Load("astroid"),astPos,Quaternion.identity) as GameObject;
    }
 }
 
 // Update is called once per frame
 void Update () 
  {
  	spawnAsteroid -= Time.deltaTime;
  
 	 if(spawnAsteroid < 0)
  		{
  			Vector3 astPos = new Vector3(Random.Range(-10,10),0,Random.Range(-5,5));
     		GameObject ast = Instantiate(Resources.Load("asteroid"),astPos,Quaternion.identity) as GameObject;
   			spawnAsteroid = 10;
  		}
  
  }
}