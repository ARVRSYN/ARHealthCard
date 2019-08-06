using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToward : MonoBehaviour {

	float time = 2f;
	public string cardObjectName;
	public Transform endPositionGO;
	public float speed;
	public float startX;
	public float startY;
	public float startZ;
	private bool delayFlag = false;
	// Use this for initialization
	void Start(){

		transform.position = new Vector3 (startX, startY, startZ);
		transform.localScale = new Vector3(0F, transform.localScale.y, transform.localScale.z);

	}
	// Update is called once per frame
	void Update () {

		if (GameObject.Find (cardObjectName).GetComponent<RecognitionController> ().detected == true) {
			//Debug.Log ("In MoveToward, detected = " + GameObject.Find ("card").GetComponent<RecognitionController> ().detected);

			if (time >= 0) {
				time -= Time.deltaTime;
			} else {
				transform.localScale = new Vector3 (0.09302086F, transform.localScale.y, transform.localScale.z);
				transform.position = Vector3.MoveTowards (transform.position, endPositionGO.position, speed * Time.deltaTime);
			}
		} else {
			time = 1.3f;
			transform.position = new Vector3 (startX, startY, startZ);
			delayFlag = false;
			transform.localScale = new Vector3(0F, transform.localScale.y, transform.localScale.z);
		//	Debug.Log ("In MoveToward, detected = " + GameObject.Find (cardObjectName).GetComponent<RecognitionController> ().detected);

		}
	}

}
