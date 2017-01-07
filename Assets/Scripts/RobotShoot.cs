using UnityEngine;
using System.Collections;

public class RobotShoot : MonoBehaviour {

	public Transform shootPosition;
	bool isShootPositionLeft;
	Animator animator;
	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			if(!animator.GetBool("isRobotMoving"))
			{
				animator.SetBool ("isRobotShooting", true);
			}
			isShootPositionLeft = this.GetComponent<SpriteRenderer> ().flipX;
			flipShootPosition (isShootPositionLeft);
			GameObject bullet = Instantiate (Resources.Load ("Bullet", typeof(GameObject)), shootPosition.position, Quaternion.identity) as GameObject;
			bullet.GetComponent<BulletBehaviours> ().isLeft = isShootPositionLeft;

		}
	}

	void flipShootPosition(bool isLeft)
	{
		Vector3 tempShootPosition = this.shootPosition.localPosition;
		if ((isLeft && tempShootPosition.x > 0) || (!isLeft && tempShootPosition.x < 0)) {
		
			tempShootPosition.x = -this.shootPosition.localPosition.x;
		}
		this.shootPosition.localPosition = tempShootPosition;
		
	}

	public void stopShootAnimation()
	{
		animator.SetBool ("isRobotShooting", false);

	}

}
