using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDMovement : MonoBehaviour {
	private static KeyCode kbPanUp = KeyCode.W;
	private static KeyCode kbPanDown = KeyCode.S;
	private static KeyCode kbPanLeft = KeyCode.A;
	private static KeyCode kbPanRight = KeyCode.D;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var camera = GetComponent<Camera> ();        //Get game camera
		var pos = camera.transform.position;
		
		if(Input.GetKey(kbPanUp)){
			pos.y += 1;
		} else if (Input.GetKey(kbPanDown)){
			pos.y -= 1;
		}
		if(Input.GetKey(kbPanLeft)){
			pos.x -= 1;
		} else if (Input.GetKey(kbPanRight)){
			pos.x += 1;
		}
		
		camera.transform.position = pos;
		
	}
}