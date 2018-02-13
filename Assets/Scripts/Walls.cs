using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour {


	public GameObject player;


	void Awake()
	{
		player = GameObject.Find ("Player"); 
	}


	void OnCollisionEnter(Collision player)
	{
		FindObjectOfType<AudioManager> ().Play ("CarCrash"); 
		//CONTROLLER VIBRATION... ------------------------do this -----------------
	}


}
