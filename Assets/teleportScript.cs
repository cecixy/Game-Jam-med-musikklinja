using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportScript : MonoBehaviour {

	public float xPos;
	public float yPos;
	public float zPos;


	public bool playerTeleported; 

	void Update()
	{
		if (playerTeleported)
			playerTeleported = false; 
	}

    private void OnTriggerEnter(Collider other)
    {                                        //x  y  z
		other.transform.position = new Vector3(xPos, yPos, zPos); 
		playerTeleported = true; 
    }

}
