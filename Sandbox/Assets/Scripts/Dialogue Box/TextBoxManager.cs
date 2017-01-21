using System.Collections;
using UnityEngine;
using UnityEngine.UI;

/**
 * Written following Tutorial: https://youtu.be/ehmBIP5sj0M
 */

public class TextBoxManager : MonoBehaviour {

	public GameObject textBox;
	public Text theText;

	public TextAsset textFile;
	public string[] textLines;

	public int currentLine;
	public int endAtLine;

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
				textLines [i] = textLines [i] + "\n — ( " + i + " / " + endAtLine + " )";
			}
		}

	}

	void Update() {
		//Actively set the current text to the current line
		if (currentLine < textLines.Length) {
			//Prevent index going out of bounds...
			theText.text = textLines [currentLine]; //Set displayed text
			/**
		 * Input.GetKeyDown ("Fire1") || 
		 * Input.GetKeyDown ("Fire2") || 
		 * Input.GetKeyDown ("Fire3") || 
		 * Input.GetKeyDown ("Jump") ||  
		*/

			if ((Input.GetKeyDown (KeyCode.Return)) && (textBox.active)) {
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
			textBox.SetActive(false);
		}

		if (currentLine > endAtLine) {
			textBox.SetActive(false);
		}
	}
}
