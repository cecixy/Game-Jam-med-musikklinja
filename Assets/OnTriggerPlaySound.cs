using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerPlaySound : MonoBehaviour {


	void OnTriggerEnter()
	{
		FindObjectOfType<AudioManager> ().Play ("Coffee"); 

	}


}
