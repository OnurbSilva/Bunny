using UnityEngine;
using System.Collections;

public class bunnyControler : MonoBehaviour {

	private Rigidbody2D myRigidBody;
	public float bunnyjump = 500;

	// Use this for initialization
	void Start () {

		myRigidBody = GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonUp("Jump")) 
		{

			myRigidBody.AddForce (transform.up * bunnyjump);
		}
			
	
	}
}
