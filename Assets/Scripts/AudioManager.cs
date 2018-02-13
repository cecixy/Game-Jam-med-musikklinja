using UnityEngine.Audio;
using System; 
using UnityEngine;

public class AudioManager : MonoBehaviour {

	//Audiomanager to easily add or remove sounds as we go
	//each sound has some different properties (audioclip, volume and pitch setting, loop bool ...)
	//when we start the game, we go through the list, for each item we add an audio source with the appropriate settings
	//when we want to play a sound we call a play-method on the audiomanager, where we input the name of the sound we want to play, the audiomanager will then find the source with that name and play the sound 



	public Sound[] sounds; 


	void Awake()
	{
		foreach (Sound s in sounds) 		//for each sound (called s) in our sounds array we want to add an audio source component
		{
			s.source = gameObject.AddComponent<AudioSource> (); 
			s.source.clip = s.clip; 

			s.source.volume = s.volume;
			s.source.pitch = s.pitch; 
		}
	}

	public void Play (string name)
	{
		Sound s = Array.Find (sounds, sound => sound.name == name);
		s.source.Play(); 
	}

	public void Pause (string name)
	{
		Sound s = Array.Find (sounds, sound => sound.name == name);
		s.source.Pause(); 
	}

}
