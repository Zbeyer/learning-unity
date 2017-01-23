using System.Collections;
using UnityEngine;

/**
 * Written following Tutorial: https://youtu.be/ehmBIP5sj0M
 */

public class ActivateTextAtLine : MonoBehaviour {

	public TextAsset theText;

	public int startLine;
	public int endLine;

	public bool locksMovement;
	public bool enumerateText;
	public bool destroyWhenActived;

	public TextBoxManager textManager;

	// Use this for initialization
	void Start () {
		textManager = FindObjectOfType<TextBoxManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other) {

		if (other.name == "Player") {
			textManager.ReloadText (theText);
			textManager.currentLine = startLine;

			if (enumerateText) {
				for (int i = 0; i < textManager.textLines.Length; i++) {
					//Zbeyer TODO: this should really be a method on the manager...
					if (textManager.textLines [i].Length > 0) {
						textManager.textLines [i] = textManager.textLines [i] + "\n — ( " + (i + 1) + " / " + (textManager.endAtLine + 1) + " )";
					}
				}
			}

			for (int i = 0; i < textManager.textLines.Length; i++) {
				//Zbeyer TODO: this should really be a method on the manager...
				if (textManager.textLines [i].Length > 0) {
					string text = textManager.textLines [i];
					text = text.Replace ("... ", "...\n");
					text = text.Replace ("(PRESS", "\n(PRESS");
					textManager.textLines [i] = text;
				}
			}

			if (endLine > 0) {
				textManager.endAtLine = endLine;
			} else {
//				endAtLine = textLines.Length - 1;
			}

			textManager.stopPlayerMovement = locksMovement;
			textManager.EnableTextBox ();
		}

		if (destroyWhenActived) {
			Destroy(gameObject);
		}
	}
}
