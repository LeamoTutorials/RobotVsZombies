using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;	
public class DoorManager : MonoBehaviour {

	Animator animator;
	public string level;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void openTheDoor()
	{
		animator.SetBool ("openTheDoor", true);
		this.GetComponent<BoxCollider2D> ().isTrigger = true;
	}

	void OnTriggerStay2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Robot") {
			SceneManager.LoadScene (level, LoadSceneMode.Single);
		}
	}


}
