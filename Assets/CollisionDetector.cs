using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public ParticleSystem part;
    public List<ParticleCollisionEvent> collisionEvents;

	public AudioClip[] sfx;
	public AudioSource sfxSource;


	void PlayRandomPlop()
	{
		int RandClip = Random.Range (0, sfx.Length);
		sfxSource.clip = sfx [RandClip];
		sfxSource.Play ();
	}

    void Start()
    {
        // part = GetComponent<ParticleSystem>();
        collisionEvents = new List<ParticleCollisionEvent>();
    }

    void OnParticleCollision(GameObject other)
    {
		// if(other.CompareTag("hand"))
		// {
		PlayRandomPlop ();
		// }
        /* int numCollisionEvents = part.GetCollisionEvents(other, collisionEvents);

        Rigidbody rb = other.GetComponent<Rigidbody>();
        int i = 0;

        while (i < numCollisionEvents)
        {
            if (rb)
            {
				// 
            }
            i++;
		}*/
    }
}