using UnityEngine;
using System.Collections;

public class WallCollision : MonoBehaviour 
{
	public Transform opositeWall;
	
	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player")
		{
			col.transform.position = opositeWall.position;
		}
		if (col.gameObject.name == "bullet(Clone)")
		{
			col.transform.position = opositeWall.position;
		}
		if (col.gameObject.name == "asteroid")
		{
			col.transform.position = opositeWall.position;
		}
	}
}
