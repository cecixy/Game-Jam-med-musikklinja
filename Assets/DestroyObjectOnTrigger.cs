using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectOnTrigger : MonoBehaviour {


	void OnTriggerEnter(Collider other)
	{
		Destroy (gameObject); 
	}


}
