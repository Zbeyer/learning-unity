using UnityEngine;
using System.Collections;

public class PixelPerfectCamera : MonoBehaviour {
	
	public static float pixelsToUnits = 1f;
	public static float scale = 1f;
	
	public Vector2 nativeResolution = new Vector2 (240, 160);
	
	void Awake () {
		var camera = GetComponent<Camera> ();		//Get game camera
		
		
		if (camera.orthographic) {
			//Script assumes 2D Game Type
			scale = Screen.height/nativeResolution.y;	//get screen to resolution ratio
			pixelsToUnits *= scale;	//Apply to PPU
			
			//NOTE: Unity puts the 0 position in the middle of the screen
			camera.orthographicSize = (Screen.height / 2.0f) / pixelsToUnits;
		}
	}
	
}