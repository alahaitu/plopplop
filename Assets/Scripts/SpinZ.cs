using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinZ : MonoBehaviour {

    public float speed = 2f;
    
    void Update ()
    {
        transform.Rotate(new Vector3 (transform.localPosition.x, transform.localPosition.y, transform.localPosition.y) * (speed * Time.deltaTime));
    }
}
