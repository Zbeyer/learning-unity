using System.Collections;
using UnityEngine;

public class LightSwitch : MonoBehaviour {
	public Light light;


//	function OnTriggerEnter(col: Collider){ if (col.tag == "Player") enableLight = true; }

//	function OnTriggerExit(col: Collider){ if (col.tag == "Player") enableLight = false; }

//	function OnGUI(){ if (enableLight){ GUI.Label(Rect(10,Screen.height-50, 300, 40), "Press L to toggle light"); } }

//	function Update(){ if (enableLight){ // if enableLight is true... if (Input.GetKeyDown("l")){ // and L pressed... pLight.light.enabled = !pLight.light.enabled; // toggle light } } else { // turn light off if enableLight is false pLight.light.enabled = false; } }


	void ActivateLightSwitch () {
		light.enabled = true;

	}

	void OnTriggerEnter(Collider other) {
		if (other.name == "Player") {
			ActivateLightSwitch ();
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.name == "Player") {
			ActivateLightSwitch ();
		}
	}
}