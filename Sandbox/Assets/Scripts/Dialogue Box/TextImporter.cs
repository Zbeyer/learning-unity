using System.Collections;
using UnityEngine;

/**
 * Written following Tutorial: https://youtu.be/ehmBIP5sj0M
 */

public class TextImporter : MonoBehaviour {

	public TextAsset textFile;
	public string[] textLines;

	// Use this for initialization
	void Start () {
		if (textFile != null) {
			textLines = (textFile.text.Split ('\n'));

		}
	}
}
