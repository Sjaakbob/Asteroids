﻿using UnityEngine;
using System.Collections;

public class RemoveBullet : MonoBehaviour {
	
	public float time;
	// Use this for initialization
	void Start () {
		Destroy(gameObject, time);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
