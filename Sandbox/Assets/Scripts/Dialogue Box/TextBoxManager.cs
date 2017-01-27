using System.Collections;
using UnityEngine;
using UnityEngine.UI;

/**
 * Written following Tutorial: https://youtu.be/ehmBIP5sj0M
 */

public class TextBoxManager : MonoBehaviour {

	public GameObject textBox;
	public Text theText;
	public Text scrollCountText;
	public float scrollSpeedValue = 0.25f;

	public TextAsset textFile;
	public string[] textLines;

	public int currentLine;
	public int endAtLine;
	public int numberOfScrolls = 0;

	public bool isActive;
	public bool stopPlayerMovement;

	public PlayerController player;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController> ();

		if (textFile != null) {
			//Split by carriage returns
			textLines = (textFile.text.Split ('\n'));
		}

		if (endAtLine == 0) {
			//Size of array indexes at 1, array indexes at 0. length - 1 is the last line of the text file.
			endAtLine = textLines.Length - 1;
		}

		if (endAtLine >= textLines.Length) {
			endAtLine = textLines.Length - 1;
		}
			
		//ZBEYER TODO: remove line numbering before using outside sandbox...
		//If I ever retool this script for a real product, this line numbering wouldn't be necessary...
		for (int i = 0; i < textLines.Length; i++) {
			if (textLines [i].Length > 0) {
				textLines [i] = textLines [i] + "\n — ( " + (i + 1) + " / " + (endAtLine + 1) + " )";
			}
		}

		for (int i = 0; i < textLines.Length; i++) {
			//Zbeyer TODO: this should really be a method on the manager...
			if (textLines [i].Length > 0) {
				string text = textLines [i];
				text = text.Replace ("... ", "...\n");
				text = text.Replace ("(PRESS", "\n(PRESS");
				textLines [i] = text;
			}
		}

		if (isActive) {
			EnableTextBox ();
		} else {
			DisableTextBox ();
		}

	}

	void Update() {

		if (!isActive) {
			return;
		}

		//Actively set the current text to the current line
		if (Input.GetKeyDown (KeyCode.Q)) {
			DisableTextBox ();
		}
			

		if (currentLine < textLines.Length) {
			//Prevent index going out of bounds...
			theText.text = textLines [currentLine]; //Set displayed text
			/**
		 * Input.GetKeyDown ("Fire1") || 
		 * Input.GetKeyDown ("Fire2") || 
		 * Input.GetKeyDown ("Fire3") || 
		 * Input.GetKeyDown ("Jump") ||  
		*/

			if (Input.GetKeyDown (KeyCode.Return)) {
				if ((textLines.Length) > currentLine) {
					currentLine += 1;

					while ((currentLine < textLines.Length) 
						&&(textLines [currentLine] == "") 
						&& (currentLine < endAtLine)) {
						//ZBeyer— this prevents having empty lines 
						currentLine += 1;
					}
				}
			}
		} else {
			DisableTextBox ();
		}

		if (currentLine > endAtLine) {
			DisableTextBox ();
		}
	}


	public void EnableTextBox() {
		textBox.SetActive(true);
		isActive = true;

		if (stopPlayerMovement) {
			player.isCanMovePlayer = false;
		}
	}

	public void DisableTextBox() {
		textBox.SetActive(false);
		isActive = false;

		player.isCanMovePlayer = true;
	}

	public void ReloadText(TextAsset newText) {
		if(newText != null) {
			if(textFile != newText) {
				textFile = newText;

				textLines = new string[1];
				textLines = (textFile.text.Split ('\n'));
				endAtLine = textLines.Length - 1;
			}
		}
	}

	public void PickUpScroll() {
		numberOfScrolls++;
		player.moveSpeed += scrollSpeedValue;
		scrollCountText.text = "Scrolls Collected: " + numberOfScrolls;
	}
}
