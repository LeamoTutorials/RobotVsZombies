using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;	

public class HealthManager : MonoBehaviour {

	public string levelToLoad;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void characterKilled()
	{
		if (this.transform.childCount > 1) {
			Destroy (this.transform.GetChild (0).gameObject);
		} else {
			SceneManager.LoadScene (levelToLoad, LoadSceneMode.Single);
		}
	}
}
