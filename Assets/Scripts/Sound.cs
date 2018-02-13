using UnityEngine.Audio;
using UnityEngine;


//tutorial: https://www.youtube.com/watch?v=6OT43pvUyfY

[System.Serializable]
public class Sound {			//don't want it to derive from monobehaviour

	public string name; 

	public AudioClip clip; 

	public float volume;			//see tutorial at about 6.50 to add sliders on the floats / a string name over the audioclip
	public float pitch; 


	[HideInInspector]
	public AudioSource source; 

}
