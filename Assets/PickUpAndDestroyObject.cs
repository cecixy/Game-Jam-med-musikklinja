using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAndDestroyObject : MonoBehaviour {



	void OnTriggerEnter(Collider other)
	{

		FindObjectOfType<AudioManager> ().Play ("OhNo"); 
		Destroy(gameObject);
		if (transform.parent != null) 
		{
			Destroy (transform.parent.gameObject); 				//DESTROY THE FKING PARENT MAN... ..Now destroys parent

			
		}
	}

	/* ///////////////////////////////////////		FIX FLOOOORS	/////////////////////////// 

	 OnTriggerEnter
	 Turn off box collider of parent
	 turn off meshRenderer of parent

	Wait 2 seconds

	Turn on box coll of parent
	Turn on meshRenderer of parent



	CHILDSCRIPT

	OnTriggerEnter 
	{
		ParentScript.FloorDisappearing(); 
	}


	PARENTSCRIPT

	(or bool)




	void FloorDisappearing
	MeshRenderer meshRenderer = GetComponent<MeshRenderer> (); 
	meshRenderer.enabled = false; 

	*/
}
