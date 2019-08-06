using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarGraphController : MonoBehaviour {

	public float delay;
	private float time;
	public string cardObjectName;
	public Transform endPositionGO;
	public float speed;
	public float startX;
	public float startY;
	public float startZ;
	private bool delayFlag = false;
	public float stopY;
	// Use this for initialization
	void Start(){

		transform.position = new Vector3 (startX, startY, startZ);
		transform.localScale = new Vector3(0F, 0F, 0F);
		time = delay;

	}
	// Update is called once per frame
	void Update () {

		if (GameObject.Find (cardObjectName).GetComponent<RecognitionController> ().detected == true) {
			//Debug.Log ("In MoveToward, detected = " + GameObject.Find ("card").GetComponent<RecognitionController> ().detected);

			if (time >= 0) {
				time -= Time.deltaTime;
			} else {
				

				transform.localScale = new Vector3 (0.15F, 0.32443F, 0.14241F);
			//	transform.position = new Vector3 (startX, startY, startZ);
				transform.position = Vector3.MoveTowards (transform.position, endPositionGO.position, speed * Time.deltaTime);

				Debug.Log ("transform.position.z = " + transform.position.z);
				//transform.position = new Vector3(transform.position.x, -1.5F, transform.position.z);
				Debug.Log ("transform.position.y = " + transform.position.y + "\n------\n");
	

			}
		} else {
			time = delay - 0.7F;
			transform.position = new Vector3 (startX, -0.172F, startZ);
			delayFlag = false;
			transform.localScale = new Vector3(0F, 0F, 0F);
			//	Debug.Log ("In MoveToward, detected = " + GameObject.Find (cardObjectName).GetComponent<RecognitionController> ().detected);

		}
	}

}
