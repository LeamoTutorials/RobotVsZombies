using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour {
	GameObject respawner;
	GameObject robotHealthBar;

	// Use this for initialization
	void Start () {
		respawner = GameObject.Find("respawner");
		robotHealthBar = GameObject.Find ("robotHealthBar");
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}


	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Robot") {
			robotHealthBar.GetComponent<HealthManager> ().characterKilled ();
			coll.transform.position = respawner.transform.position;
		}
		if (coll.gameObject.tag == "Zombie") {
			Destroy (coll.gameObject);
		}
	}
}
