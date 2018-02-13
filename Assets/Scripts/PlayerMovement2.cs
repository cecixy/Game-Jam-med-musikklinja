using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour {

	[SerializeField]

	public float speed = 5f; 

	[SerializeField]
	public float lookSensitivity = 3f; 

	private PlayerMotor motor; 

	void Start () {
		motor = GetComponent<PlayerMotor> (); 
	}
	
	void Update () {
		//Calculate movement velocity as a 3D vector
		float _xMov = Input.GetAxisRaw("Horizontal"); 		//LHorizontal for controller
		float _zMov = Input.GetAxisRaw ("Vertical"); 		//LVertical for controller

		Vector3 movHorizontal = transform.right * _xMov; 
		Vector3 movVertical = transform.forward * _zMov; 

		//Final movement vector
		Vector3 _velocity = (movHorizontal + movVertical).normalized * speed; 

		//Apply movement
		motor.Move(_velocity); 


		//Calculate rotation as a 3D vector (turning around)
		float _yRot = Input.GetAxisRaw("Mouse X"); 						//"Mouse X" to make it follow the mouse in the X-axis //RHorizontal to make camera rotate on the x-axis

		Vector3 _rotation = new Vector3 (0f, _yRot, 0f) * lookSensitivity; 

		//Apply rotation
		motor.Rotate(_rotation); 




				//THIS IS FOR CAMERA ROTATION UP AND DOWN. DISABLING IT FOR THIS PROJECT. 

		//Calculate CAMERA ROTATION as a 3D vector (look UP AND DOWN)
		float _xRot = Input.GetAxisRaw("Mouse Y"); 								//"Mouse Y" to make it follow the mouse in the Y-axis

		Vector3 _cameraRotation = new Vector3 (_xRot, 0f, 0f) * lookSensitivity; 

		//Apply CAMERA ROTATION
		motor.RotateCamera(_cameraRotation); 




	}
}
