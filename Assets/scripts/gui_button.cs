using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gui_button : MonoBehaviour {


	public bool showing = false;
	public Color color;
	public Texture2D image = null;

	[ExecuteInEditMode]
	private void OnGUI()
	{
		GUIStyle guiStyle = new GUIStyle ("button");
		guiStyle.fontSize = 20;
		guiStyle.normal.textColor = Color.white;



		if(GUI.Button (new Rect (30, 30, 500, 500), "This is some text", guiStyle))
		{
				Debug.Log("button pressed");
				showing = true;
		} 

			if(showing)
			{
			
				GUI.DrawTexture(new Rect(30, 30, 500, 500), image);
			}

	}
}
