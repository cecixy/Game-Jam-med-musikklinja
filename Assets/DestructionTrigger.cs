using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionTrigger : MonoBehaviour {


	void OnTriggerEnter(Collider other)
	{
		FindObjectOfType<AudioManager> ().Play ("OhNo"); 
		Destroy(gameObject);
		if (transform.parent != null) 
		{
			Destroy (transform.parent.gameObject); 				//DESTROY THE FKING PARENT MAN... ..Now destroy parent
		}
	}


}
