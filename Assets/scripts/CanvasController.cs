using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour {

	public bool canvasButton = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		Debug.Log ("Canvas has been clicked!");
		if (canvasButton == true) {
			GameObject.Find ("transactions").transform.localScale = new Vector3 (0, 0, 0);

			canvasButton = false;
		}
	}
}
