using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class merchTrans1Anim : MonoBehaviour {

	private Animator anim;
	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TriggerAnimation()
	{
		anim.SetTrigger ("recognized");
	}
}
