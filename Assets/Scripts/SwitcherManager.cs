using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitcherManager : MonoBehaviour {

	public GameObject doorToOpen;
	Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Robot" && Input.GetKey (KeyCode.X)) {
			animator.SetBool ("switchOn", true);
			doorToOpen.GetComponent<DoorManager> ().openTheDoor ();
		}
	}
}
