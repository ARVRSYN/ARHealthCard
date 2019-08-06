using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MerchController : MonoBehaviour, IPointerClickHandler {

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

		if (isShowing == true) 
		{
			this.gameObject.transform.localScale = new Vector3(0, 0, 0);
			isShowing = false;
		}
	}
}
