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
		Debug.Log("Music Manager start");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void PlayRandomPlop()
	{
		int RandClip = Random.Range (0, sfx.Length);
		sfxSource.clip = sfx [RandClip];
		sfxSource.Play ();
	}

	void OnParticleCollision(GameObject other)
	{
		Debug.Log("on particle collision");
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("on trigger enter", other);
		if(other.CompareTag("hand"))
		{
			PlayRandomPlop ();
		}
	}
}
