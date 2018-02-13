using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointBehaviour : MonoBehaviour {

	public GameObject player;

	void Awake()
	{
		player = GameObject.Find ("Player"); 
	}


	void OnTriggerEnter(Collider player)
	{
		FindObjectOfType<AudioManager> ().Play ("PickUpSeagull"); 
		Destroy(gameObject); 
	}
		
}
