using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scenario1 : MonoBehaviour {

	public Text dialogue;
	public TextAsset textFile;
	private string[] textLines;
	private int currentLine = 0;
	private int endAtLine = 0;

	private float timer = 0f;
	private bool wait = false;

	// Use this for initialization
	void Start () {
		if (textFile != null) {
			textLines = (textFile.text.Split('\n'));
		}
		if (textFile != null && endAtLine == 0) {
			endAtLine = textLines.Length - 1;
		}
		if (textLines != null)
			dialogue.text = textLines[currentLine];
	}

	// Update is called once per frame
	void Update () {
		if (wait)
		{
			timer += Time.deltaTime;
			if (timer >= 0.25f) 
			{
				wait = false;
				dialogue.CrossFadeAlpha(1f, 0.5f, false);
			}
		}
		if (Input.GetKeyDown(KeyCode.Space)) {
			currentLine++;
			if (textLines != null && currentLine <= endAtLine)
				dialogue.text = textLines[currentLine];
			fadeInOut();
		}
		if (currentLine > endAtLine) {
			Application.LoadLevel("Level1");
		}
	}

	public void fadeInOut()
	{
		dialogue.canvasRenderer.SetAlpha(0.01f);
		dialogue.CrossFadeAlpha(0.0f, 0.5f, false);
		timer = 0;
		wait = true;
	}
}
