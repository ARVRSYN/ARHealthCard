using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class clickControl : MonoBehaviour {

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

	void OnMouseUp()
	{
		if(!IsPointerOverUIObject() && !canvasObjectsShowingUp()) {
			if (this.gameObject.name == "merchTrans1") {
				GameObject.Find ("merchTrans1_popup").GetComponent<MerchController> ().isShowing = true;
				//yield return new WaitForSeconds (1);
				GameObject.Find ("merchTrans1_popup").transform.localScale = new Vector3 (46, 23, 5);
			} else if (this.gameObject.name == "merchTrans2") {
				GameObject.Find ("merchTrans2_popup").GetComponent<MerchController> ().isShowing = true;
				//yield return new WaitForSeconds (1);
				GameObject.Find ("merchTrans2_popup").transform.localScale = new Vector3 (46, 23, 5);
			} else if (this.gameObject.name == "merchTrans3") {
				GameObject.Find ("merchTrans3_popup").GetComponent<MerchController> ().isShowing = true;
				//yield return new WaitForSeconds (1);
				GameObject.Find ("merchTrans3_popup").transform.localScale = new Vector3 (46, 23, 5);
			} else if (this.gameObject.name == "merchTrans4") {
				GameObject.Find ("merchTrans4_popup").GetComponent<MerchController> ().isShowing = true;
				//yield return new WaitForSeconds (1);
				GameObject.Find ("merchTrans4_popup").transform.localScale = new Vector3 (46, 23, 5);
			} else if (this.gameObject.name == "right_menu") {
				GameObject.Find ("payment_popup").GetComponent<MerchController> ().isShowing = true;
				GameObject.Find ("payment_popup").transform.localScale = new Vector3 (46, 23, 5);
			}
		}
	}


	private bool IsPointerOverUIObject() {
		PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
		eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		List<RaycastResult> results = new List<RaycastResult>();
		EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
		return results.Count > 0;
	}

	private bool canvasObjectsShowingUp() {
		return (GameObject.Find ("merchTrans1_popup").GetComponent<MerchController> ().isShowing
			|| GameObject.Find ("merchTrans2_popup").GetComponent<MerchController> ().isShowing
			|| GameObject.Find ("merchTrans3_popup").GetComponent<MerchController> ().isShowing
			|| GameObject.Find ("merchTrans4_popup").GetComponent<MerchController> ().isShowing
			|| GameObject.Find ("payment_popup").GetComponent<MerchController> ().isShowing);
	}


}
