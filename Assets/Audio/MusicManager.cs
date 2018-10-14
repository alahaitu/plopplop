using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicManager : MonoBehaviour 
{
	public static MusicManager musics;

	public AudioClip[] sfx;
	public AudioSource sfxSource;
	public GameObject hand;

//	ParticleSystem bubbles;
//	ParticleCollisionEvent[] particleCollisionEvent;

	void Awake()
	{
//		bubbles = GetComponent<ParticleSystem> ();
//		particleCollisionEvent = new ParticleCollisionEvent[7];
	}

	// Use this for initialization
	void Start () 
	{
		musics = this;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void PlayRandomPlop()
	{
		int randClip = Random.Range (0, sfx.Length);
		sfxSource.PlayOneShot (sfx[randClip], 1);
		sfxSource.Play ();
	}

	void OnParticleCollision (GameObject other)
	{
//		int safeLength = bubbles.GetSafeCollisionEventSize();
//		if (particleCollisionEvent.Length < safeLength)
//			particleCollisionEvent = new ParticleCollisionEvent[safeLength];
//
//		int totalCollisions = bubbles.GetCollisionEvents(other, particleCollisionEvent);
//		for (int i = 0; i < totalCollisions; i++)
//			AudioSource.PlayClipAtPoint(sfxSource, particleCollisionEvent[i].intersection);
//
//		print (totalCollisions);

		if (hand.gameObject.CompareTag ("hand")) {
			PlayRandomPlop ();
		}
	}
}
