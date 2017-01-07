using UnityEngine;
using System.Collections;

public class BulletBehaviours : MonoBehaviour {

	Vector3 tempBulletPosition;
	public bool isLeft;
	public float speed = 0.5f;
	public float timeLeft = 1f;
	// Use this for initialization
	void Start () 
	{
		if (isLeft) {
			speed = -speed;
			this.GetComponent<SpriteRenderer> ().flipX = true;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		tempBulletPosition = this.transform.position;
		tempBulletPosition.x += speed;
		this.transform.position = tempBulletPosition;
		timeLeft -= Time.deltaTime; 
		if (timeLeft < 0) {
			Destroy (this.gameObject);
		}

	}
}
