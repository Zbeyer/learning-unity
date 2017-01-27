using System.Collections;
using UnityEngine;

public class Scroll : MonoBehaviour {

	public TextBoxManager textManager;


	void OnTriggerEnter(Collider other) {
		if (other.name == "Player") {
			if (textManager) {
				textManager.PickUpScroll ();
			}
		}
		Debug.Log ("TRIGGER!" + other.tag);;;
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.name == "Player") {
			if (textManager) {
				textManager.PickUpScroll ();
			}
		}
	}
}
