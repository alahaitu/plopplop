using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByTouch : MonoBehaviour
{

    public Vector3 startPoint;
    private float startTime;
    private Vector3 clickedPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    // Update is called once per frame 

    void Update()
    {
        /*     if (Input.GetButtonDown("Fire1"))
             {
                 Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                 if (Physics.Raycast(ray))
                    // Instantiate(particle, transform.position, transform.rotation);
                     transform.position = Input.mousePosition;

             }*/

        if (Input.GetMouseButtonDown(1)) // right mouse button
        {
            clickedPosition = Camera.main.ScreenToWorldPosition(Input.mousePosition);
            transform.position = Vector3.Lerp(startPoint, clickedPosition, (Time.time - startTime) / 1.0f);
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;
            transform.position = touchPosition;
            Debug.Log("Touch happening" + touchPosition);

        }
    }
}