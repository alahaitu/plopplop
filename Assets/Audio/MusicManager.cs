using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicManager : MonoBehaviour 
{
	public AudioClip[] sfx;
	public AudioSource sfxSource;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void PlayRandomPlop()
	{
		int RandClip = Random.Range (0, sfx.Length);
		sfxSource.clip = sfx [RandClip];
		sfxSource.Play ();
	}
}
