using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;

	public bool isCanMovePlayer = true;
//	private Animator anim;

	// Use this for initialization
	void Start () {
//		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (!isCanMovePlayer) {
			return;
		}

		if (Input.GetAxisRaw ("Horizontal") > 0.5f || Input.GetAxisRaw ("Horizontal") < -0.5f) {
			transform.rotation = Quaternion.Euler(0, 0, 0); 
			transform.Translate (
				new Vector3(
					Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime,
					0f,
					0f
				));
		}

		if (Input.GetAxisRaw ("Vertical") > 0.5f || Input.GetAxisRaw ("Vertical") < -0.5f) {
			//3D Control always consistant
			transform.rotation = Quaternion.Euler(0, 0, 0); 

			transform.Translate (
				new Vector3(
					0f, 
					Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 
					0f));


		}

	}
}
