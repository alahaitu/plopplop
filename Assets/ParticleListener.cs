using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleListener : MonoBehaviour {
	public ParticleSystem particleLauncher;

    List<ParticleCollisionEvent> collisionEvents;

	// Use this for initialization
	void Start () {
		Debug.Log("particle listener");
		collisionEvents = new List<ParticleCollisionEvent> ();
	}

	void OnParticleCollision(GameObject other)
    {
		Debug.Log("on partcile collision");
        ParticlePhysicsExtensions.GetCollisionEvents (particleLauncher, other, collisionEvents);

        for (int i = 0; i < collisionEvents.Count; i++) 
        {
            // splatDecalPool.ParticleHit (collisionEvents [i], particleColorGradient);
            // EmitAtLocation (collisionEvents[i]);
			Debug.Log("collision event");
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
