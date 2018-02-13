using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed = 2f; 

	private Vector3 moveInput; 
	private Vector3 moveVelocity; 

	private Rigidbody rb2d; 
	private Camera mainCamera; 


	void Start () 
	{
		rb2d = GetComponent<Rigidbody> ();
		mainCamera = FindObjectOfType<Camera> ();   
	}



	void Update () 
	{
		moveInput = new Vector3 (Input.GetAxisRaw ("LHorizontal"), 0f, Input.GetAxisRaw ("LVertical")); 			//GetAxis vs GetAxisRaw: GetAxis is smoothes based on the "sensitivity" setting, so that value gradually changes from 0 to 1 or 0 to -1. Whereas GetAxisRaw will only return 0, -1 or 1 exactly. (More common for 2D games to use GetAxisRaw and 3D games to use smoothing, but use whatever suits your game the best.) 
		moveVelocity = moveInput * moveSpeed; 

		Ray cameraRay = mainCamera.ScreenPointToRay (Input.mousePosition); 
		Plane groundPlane = new Plane (Vector3.up, Vector3.zero); 				//what does this do?
		float rayLength; 

		if (groundPlane.Raycast (cameraRay, out rayLength)) 
		{
			Vector3 pointToLook = cameraRay.GetPoint (rayLength); 
	//		Debug.DrawLine (cameraRay.origin, pointToLook, Color.magenta); 
			Debug.DrawLine (cameraRay.origin, pointToLook, Color.magenta); 

			transform.LookAt (new Vector3 (pointToLook.x, transform.position.y, pointToLook.z)); 
		}

	}

	void FixedUpdate()
	{
		rb2d.velocity = moveVelocity; 
	}
}
