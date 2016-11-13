using UnityEngine;
using System.Collections;

public class RobotMovements : MonoBehaviour {

	public float speed = 0.2f;
	Vector3 tempRobotPosition ;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		tempRobotPosition = this.transform.position;
		if (Input.GetKey (KeyCode.RightArrow)) {
			tempRobotPosition.x += speed;
			flip (false);
		} else {
			if (Input.GetKey (KeyCode.LeftArrow)) {
				tempRobotPosition.x -= speed;
				flip (true);
			}
		}
		this.transform.position = tempRobotPosition;

	}

	void flip(bool isLeft)
	{
		if (isLeft) {
			this.GetComponent<SpriteRenderer> ().flipX = true;
		} else {
			this.GetComponent<SpriteRenderer> ().flipX = false;
		}

	}
}
