using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;	

public class StartButtonBehaviours : MonoBehaviour {

	Animator animator;
	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseOver()
	{
		animator.SetBool ("mouseOver", true);
		if (Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene ("Level1", LoadSceneMode.Single);		
		}
	}

	void OnMouseExit()
	{
		animator.SetBool ("mouseOver", false);
	}
}
