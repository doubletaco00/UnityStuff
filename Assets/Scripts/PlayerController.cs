using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float jumpForce;
	public float speed;
	public Rigidbody mRigidBody;

	// Use this for initialization
	void Start () {
		mRigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		mRigidBody.AddForce (movement*speed);

		if (Input.GetKeyDown (KeyCode.Space) && transform.position.y <= 0.5) {
			Vector3 jump = new Vector3 (0.0f, jumpForce, 0.0f);
			mRigidBody.AddForce(jump);
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			Instantiate(this);
		}
	}

}
