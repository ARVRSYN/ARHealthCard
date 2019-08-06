using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RewardsController : MonoBehaviour, IPointerClickHandler {

	public bool isShowing = false;

	// Use this for initialization
	void Start () {
		this.transform.localScale = new Vector3(0, 0, 0);
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log (isShowing);
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		Debug.Log ("You clicked the transactions image! isShowing = " + isShowing);

		if (isShowing == true) 
		{
			Debug.Log ("You're almost there!");
			GameObject.Find ("rewards_popup").transform.localScale = new Vector3(0, 0, 0);
			isShowing = false;
		}
	}
}
