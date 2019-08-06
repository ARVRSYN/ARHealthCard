using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RewardClickControl : MonoBehaviour {

	public EventSystem eventSystem;
	bool clickFlag = false;
	public Texture2D image = null;
	public bool showing = false;

	// Use this for initialization
	void Start () {

		Debug.Log("Starting!");

	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown()
	{
		if(!eventSystem.IsPointerOverGameObject()) {
			if (this.gameObject.name == "left_menu") {
				GameObject.Find ("rewards_popup").GetComponent<RewardsController> ().isShowing = true;
				//yield return new WaitForSeconds (1);
				GameObject.Find ("rewards_popup").transform.localScale = new Vector3 (7, 6, 5);
			}
		}
	}


}
