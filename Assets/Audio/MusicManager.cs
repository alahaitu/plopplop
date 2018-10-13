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
=======
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

		//hand.gameObject.CompareTag("hand")
		PlayRandomPlop ();
>>>>>>> 4d6bcfe004f00c9866b9fb933079a735a1448d6d
	}
}
