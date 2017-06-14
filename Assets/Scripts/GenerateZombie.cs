using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateZombie : MonoBehaviour {
	Animator animator;
	public float timeToGenerateZombie = 1f;
	float timeLeft;
	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator> ();
		timeLeft = timeToGenerateZombie;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (animator.GetBool ("openTheDoor")) {
			if (timeLeft < 0) {
				GameObject zombie = Instantiate (Resources.Load ("Zombie"), this.transform.position, Quaternion.identity) as GameObject;
				timeLeft = timeToGenerateZombie;
			} else {
				timeLeft -= Time.deltaTime;
			}
				
		}
		
	}
}
