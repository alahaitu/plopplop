using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

    public float speed = 0.5f;
    
    void Update ()
    {
        transform.Rotate(new Vector3 (15, 30, 45) * (speed * Time.deltaTime));
    }
}
