using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMeshrenderer : MonoBehaviour {

	// Use this for initialization
	public void ToggleMeshRenderer()
	{
		MeshRenderer meshRenderer = GetComponent<MeshRenderer> (); 
		meshRenderer.enabled = true; 
	}
}
