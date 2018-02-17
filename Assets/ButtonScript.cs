using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {



	void OnCollisionEnter(Collision other)
	{
		FindObjectOfType<AudioManager> ().Play ("Button"); 
		GetComponent<AudioSource> ().Play (); 
	}
}
