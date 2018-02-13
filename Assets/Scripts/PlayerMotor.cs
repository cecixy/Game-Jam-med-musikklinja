using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {

	 //THIS IS FOR CAMERA ROTATION UP AND DOWN. DISABLING IT FOR THIS PROJECT. 
	//FOR CAMERA ROTATION (UP AND DOWN)  
	[SerializeField]
	private Camera cam; 


	private Vector3 velocity = Vector3.zero; 
	private Vector3 rotation = Vector2.zero; 

	public bool isGrounded; 
	public Transform groundCheck;
	public float groundRadius = 0.25f; 
	public LayerMask whatIsGround; 

	public bool walking; 
	public bool playWalk;

	public float jumpForce = 350f; 

	 //THIS IS FOR CAMERA ROTATION UP AND DOWN. DISABLING IT FOR THIS PROJECT. 
	//For camera rotation (LOOK UP AND DOWN)
	private Vector3 cameraRotation = Vector3.zero; 


	private Rigidbody rb; 


	void Start () {
		rb = GetComponent<Rigidbody> (); 
	}


	//Gets a movement vector
	public void Move (Vector3 _velocity)
	{
		velocity = _velocity; 
	}

	//Gets a rotational vector
	public void Rotate (Vector3 _rotation)
	{
		rotation = _rotation; 
	}

	 //THIS IS FOR CAMERA ROTATION UP AND DOWN. DISABLING IT FOR THIS PROJECT. 
	//Gets a rotational vector FOR CAMERA (UP AND DOWN) 
	public void RotateCamera (Vector3 _cameraRotation)
	{
		cameraRotation = _cameraRotation; 
	}


	//Run every physics iteration
	void FixedUpdate()
	{
		PerformMovement (); 
		PerformRotation (); 

	}


	//Perform movement based on velocity variable 
	void PerformMovement()
	{
		if (velocity != Vector3.zero) {
			rb.MovePosition (rb.position + velocity * Time.fixedDeltaTime); 				//"MovePosition different from transform.Translate because this will stop the Rigidbody from moving there if it collides with something on the way. Easier to control than the AddForce method
			voidPlayWalk ();
		} else {
			playWalk = true;
			FindObjectOfType<AudioManager> ().Pause ("Walking"); 
		}//transform.rotation or transform.position equals rb.rotation or rb.position 
	}

	void voidPlayWalk ()
	{
		if (playWalk) {
			FindObjectOfType<AudioManager> ().Play ("Walking"); 
			playWalk = false;
		}
	}
	//Perform rotation
	void PerformRotation()
	{
		rb.MoveRotation (rb.rotation * Quaternion.Euler(rotation)); 					//Euler angles are the angles that we know, the x-, y-, and z-rotation. rb.rotation is a quaternion and Quaternion.Euler will take in our Vector3 and make it into a quaternion 
			//THIS IS FOR CAMERA ROTATION UP AND DOWN. DISABLING IT FOR THIS PROJECT. 	
	  if (cam != null) 			//so, means.. if there is a camera
		{
			cam.transform.Rotate (-cameraRotation); 			//for inverted look up and down, make cameraRotation positive
		}

	}


}
