using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWallNoSound : MonoBehaviour {




	void OnTriggerEnter(Collider other)
	{
		Destroy(gameObject);
		if (transform.parent != null) 
		{
			Destroy (transform.parent.gameObject); 				//DESTROY THE FKING PARENT MAN... ..Now destroy parent
		}
	}
}
