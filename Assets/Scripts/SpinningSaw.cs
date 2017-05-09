using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningSaw : MonoBehaviour {
	public int spinningSpeed = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate (Vector3.forward * spinningSpeed);
		
	}
}
