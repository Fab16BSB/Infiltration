using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Objectifs : MonoBehaviour 
{

	public Text objectif;
	private float timer = 0;
	private float remainTime = 8f;
	private bool wait = false;

	// Use this for initialization
	void Start () 
	{
		objectif.color = new Color(1f, 1f, 1f);
		Objectif1();
	}

	public void Objectif1() 
	{
		objectif.text = "Accédez à l'ordinateur principal au dernier étage.";
		fadeInOut();
	}

	public void HelpTrashCan() 
	{
		objectif.text = "Vous pouvez vous cacher si aucun ennemi ne vous voit.";
		fadeInOut();
	}

	public void displayInformation(Text information) {
		objectif.text = information.text;
		fadeInOut();
	}

	public void fadeInOut()
	{
		objectif.canvasRenderer.SetAlpha(0.01f);
		objectif.CrossFadeAlpha(1f, 5f, false);
		timer = 0;
		wait = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (wait)
		{
			timer += Time.deltaTime;
			if (timer >= remainTime) 
			{
				wait = false;
				objectif.CrossFadeAlpha(0.0f, 2.5f, false);
			}
		}
	}
}
