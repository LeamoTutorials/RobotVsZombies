using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviours : MonoBehaviour {

	public float speed = 1.15f;
	GameObject zombieHealthBar;
	// Use this for initialization
	void Start () {
		zombieHealthBar = GameObject.Find ("zombieHealthBar");
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 tempEnemyPosition = transform.position;
		tempEnemyPosition.x -= speed;
		transform.position = tempEnemyPosition;
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Bullet" ) {
			zombieHealthBar.GetComponent<HealthManager> ().characterKilled ();
			Destroy (coll.gameObject);
			Destroy (this.gameObject);
		}
	}
}
