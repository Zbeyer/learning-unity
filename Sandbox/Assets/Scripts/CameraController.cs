﻿using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public GameObject followTarget;
	public Vector3 targetPos;
	public float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		targetPos = new Vector3 ( followTarget.transform.position.x, 
								  followTarget.transform.position.y, 
								  followTarget.transform.position.z-10);
		
		transform.position = Vector3.Lerp (	transform.position, 
											targetPos, 
											moveSpeed * Time.deltaTime);
	}
}
