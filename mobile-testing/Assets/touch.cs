using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //Allows us to use UI.


public class touch : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		//Check if Input has registered more than zero touches
		if ((Input.touchCount > 0)||(Input.anyKeyDown))
		{
			//Store the first touch detected.
			if (Input.touchCount > 0) {
				Touch myTouch = Input.touches [0];
			//Check if the phase of that touch equals Began
			if (myTouch.phase == TouchPhase.Began)
			{
				//If so, set touchOrigin to the position of that touch
//				touchOrigin = myTouch.position;

				Debug.Log ("TOUCHED!");
			
				}			}
			
//
			if (gameObject.GetComponent<Renderer> ().material.color == Color.red) {
				gameObject.GetComponent<Renderer> ().material.color = Color.green;
			} else if (gameObject.GetComponent<Renderer> ().material.color == Color.green) {
				gameObject.GetComponent<Renderer> ().material.color = Color.blue;
			} else {
				gameObject.GetComponent<Renderer> ().material.color = Color.red;
			}



//			//If the touch phase is not Began, and instead is equal to Ended and the x of touchOrigin is greater or equal to zero:
//			else if (myTouch.phase == TouchPhase.Ended && touchOrigin.x >= 0)
//			{
//				//Set touchEnd to equal the position of this touch
//				Vector2 touchEnd = myTouch.position;
//
//				//Calculate the difference between the beginning and end of the touch on the x axis.
//				float x = touchEnd.x - touchOrigin.x;
//
//				//Calculate the difference between the beginning and end of the touch on the y axis.
//				float y = touchEnd.y - touchOrigin.y;
//
//				//Set touchOrigin.x to -1 so that our else if statement will evaluate false and not repeat immediately.
//				touchOrigin.x = -1;
//
//				//Check if the difference along the x axis is greater than the difference along the y axis.
//				if (Mathf.Abs(x) > Mathf.Abs(y))
//					//If x is greater than zero, set horizontal to 1, otherwise set it to -1
//					horizontal = x > 0 ? 1 : -1;
//				else
//					//If y is greater than zero, set horizontal to 1, otherwise set it to -1
//					vertical = y > 0 ? 1 : -1;
//			}
		}

	}
}
