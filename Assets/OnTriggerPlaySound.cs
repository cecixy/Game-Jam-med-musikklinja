using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerPlaySound : MonoBehaviour {


	private AudioSource audi; 


	void Start()
	{
		audi = GetComponent<AudioSource> (); 
	}

	void OnTriggerEnter(Collider other)
	{
		FindObjectOfType<AudioManager> ().Play ("PickUpTB"); 
	}

}
