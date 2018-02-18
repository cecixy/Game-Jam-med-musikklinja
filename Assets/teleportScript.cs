using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportScript : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {                                        //x  y  z
        other.transform.position = new Vector3(0, 5, 0); //Lag et empty gameObject der du vil at playeren skal bli telepotert til, og put de kordinatene her. 
    }

}
