using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


//probably attach something similar to this to each image attached to the card being recognized


public class RecognitionController : MonoBehaviour,
ITrackableEventHandler
{
	private TrackableBehaviour mTrackableBehaviour;
	private Animator anim;
	public bool detected;

	//public GameObject foodCube;


	//public Animator foodCubeAni;
	//public Animator entertainmentCubeAni;
	//public Animator travelCubeAni;
	//public Animator businessCubeAni;
	//public Animator leftMenuAni;
	public Animator topMenuAni;
	//public Animator bottomMenuAni;
	public Animator merchTrans1Ani;
	public Animator merchTrans2Ani;
	public Animator merchTrans3Ani;
	public Animator merchTrans4Ani;
	public Animator rightMenuAni;



	//public Transform foodCubeTrans;
	public RectTransform leftMenuTrans;

	void Start()
	{
		detected = false;
		anim = GetComponent<Animator> ();

		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
			//GameObject.Find ("merchTrans1").GetComponent<merchTrans1Anim> ().TriggerAnimation ();
			detected = true;

			//foodCube.SetActive (true);

			Debug.Log ("detected = " + detected);


			Debug.Log ("trying to change 'recognized'");

			/*
			foodCubeAni.SetBool ("onLoseRecog", false);
			entertainmentCubeAni.SetBool ("onLoseRecog", false);
			businessCubeAni.SetBool ("onLoseRecog", false);
			travelCubeAni.SetBool ("onLoseRecog", false);
			leftMenuAni.SetBool ("onLoseRecog", false);
			topMenuAni.SetBool ("onLoseRecog", false);
			bottomMenuAni.SetBool ("onLoseRecog", false);
			merchTrans1Ani.SetBool ("onLoseRecog", false);
			merchTrans2Ani.SetBool ("onLoseRecog", false);
			merchTrans3Ani.SetBool ("onLoseRecog", false);
			merchTrans4Ani.SetBool ("onLoseRecog", false);
			*/

		//	foodCubeTrans.transform.localScale = new Vector3 (0.15f, 0.3244f, 0.1424f);


			//foodCubeAni.SetBool ("recognized", true);
			//foodCube.SetActive (true);
			//entertainmentCubeAni.SetBool ("recognized", true);
			//businessCubeAni.SetBool ("recognized", true);
			//travelCubeAni.SetBool ("recognized", true);
		//	leftMenuTrans.transform.localScale = new Vector3 (0.03575528f, 0.8699332f, 0.06230916f);
			//leftMenuAni.SetBool ("recognized", true);
			topMenuAni.SetBool ("recognized", true);
			//bottomMenuAni.SetBool ("recognized", true);
			merchTrans1Ani.SetBool ("recognized", true);
			merchTrans2Ani.SetBool ("recognized", true);
			merchTrans3Ani.SetBool ("recognized", true);
			merchTrans4Ani.SetBool ("recognized", true);
			rightMenuAni.SetBool ("recognized", true);

			/*
			foodCubeAni.SetBool ("recognized", false);
			entertainmentCubeAni.SetBool ("recognized", false);
			businessCubeAni.SetBool ("recognized", false);
			travelCubeAni.SetBool ("recognized", false);
			leftMenuAni.SetBool ("recognized", false);
			topMenuAni.SetBool ("recognized", false);
			bottomMenuAni.SetBool ("recognized", false);
			merchTrans1Ani.SetBool ("recognized", false);
			merchTrans2Ani.SetBool ("recognized", false);
			merchTrans3Ani.SetBool ("recognized", false);
			merchTrans4Ani.SetBool ("recognized", false);
			*/

			if(merchTrans1Ani.GetBool("recognized").Equals(true))
			{
				Debug.Log("merchTrans1 bool 'recognized' set to 'true'");
			}




			//GameObject.Find ("FoodCube").GetComponent<Animator> ().SetBool ("recognized", true);

			// Play audio when target is found
			//audio.Play();
		}
		else
		{
			// Stop audio when target is lost
			//audio.Stop();
			//foodCubeTrans.transform.localScale = new Vector3 (0f, 0f, 0f);
		//	leftMenuTrans.transform.localScale = new Vector3 (0f, 0f, 0f);


			//foodCubeAni.SetBool ("recognized", false);
			//entertainmentCubeAni.SetBool ("recognized", false);
			//businessCubeAni.SetBool ("recognized", false);
			//travelCubeAni.SetBool ("recognized", false);
			//leftMenuAni.SetBool ("recognized", false);
			topMenuAni.SetBool ("recognized", false);
			//bottomMenuAni.SetBool ("recognized", false);
			merchTrans1Ani.SetBool ("recognized", false);
			merchTrans2Ani.SetBool ("recognized", false);
			merchTrans3Ani.SetBool ("recognized", false);
			merchTrans4Ani.SetBool ("recognized", false);
			rightMenuAni.SetBool ("recognized", false);


			/*
			foodCubeAni.SetBool ("onLoseRecog", true);
			entertainmentCubeAni.SetBool ("onLoseRecog", true);
			businessCubeAni.SetBool ("onLoseRecog", true);
			travelCubeAni.SetBool ("onLoseRecog", true);
			leftMenuAni.SetBool ("onLoseRecog", true);
			topMenuAni.SetBool ("onLoseRecog", true);
			bottomMenuAni.SetBool ("onLoseRecog", true);
			merchTrans1Ani.SetBool ("onLoseRecog", true);
			merchTrans2Ani.SetBool ("onLoseRecog", true);
			merchTrans3Ani.SetBool ("onLoseRecog", true);
			merchTrans4Ani.SetBool ("onLoseRecog", true);
			*/

			detected = false;
			Debug.Log ("detected = " + detected);

		}
	}   
}