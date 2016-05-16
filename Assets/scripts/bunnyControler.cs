using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class bunnyControler : MonoBehaviour {

	private Rigidbody2D myRigidBody;
	private Animator myAnim;
	public float bunnyjump = 500;

	// Use this for initialization
	void Start () {

		myRigidBody = GetComponent<Rigidbody2D>();
		myAnim = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonUp("Jump")) 
		{

			myRigidBody.AddForce (transform.up * bunnyjump);
		}
	
		myAnim.SetFloat ("vVelocity", myRigidBody.velocity.y);
	
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.gameObject.layer == LayerMask.NameToLayer("enemy")) 
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
	
	}
}
