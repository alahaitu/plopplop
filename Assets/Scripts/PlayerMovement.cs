using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
	private int laneNumber = 0;
	private int lanesCount = 4;
	private float laneWidth = 4.5f;
	private float firstLaneXPos = -7;
	private float deadZone = 0.1f;
	private float speed = 5;

	public TouchGesture.GestureSettings GestureSetting;
	private TouchGesture touch;

	// Use this for initialization
	void Start () 
	{
		//var shootScript = GetComponent<PlayerShooting>();

		touch = new TouchGesture(this.GestureSetting);
		//StartCoroutine(touch.CheckHorizontalSwipes(
		//	onLeftSwipe: () => { ChangeLane(laneNumber - 1); },
		//	onRightSwipe: () => { ChangeLane(laneNumber + 1); },
		//	onStationary: () => { shootScript.shootRequest = true; }
		//));
	}

	void ChangeLane(int lane) {
		Vector3 pos = transform.position;

		int maxLane = Mathf.RoundToInt ((pos.x - firstLaneXPos + 0.1f) / laneWidth + 1);
		int minLane = Mathf.RoundToInt ((pos.x - firstLaneXPos + 0.1f) / laneWidth - 1);

		if (lane < minLane)
			lane = minLane;
		else if (laneNumber > maxLane)
			lane = maxLane;

		if (lane < 0)
			lane = 0;
		else if (lane >= lanesCount)
			lane = lanesCount - 1;

		laneNumber = lane;
	}

	// Update is called once per frame
	void Update () 
	{
		//transform.Translate (Input.GetAxis ("Horizontal") * Time.deltaTime * speed, 0f, Input.GetAxis ("Vertical") * Time.deltaTime * speed);
		float input = Input.GetAxis("Horizontal");
		Vector3 pos = transform.position;

		if (Mathf.Abs (input) > deadZone) {
			ChangeLane(laneNumber + Mathf.RoundToInt (Mathf.Sign (input)));
		}


		pos.x = Mathf.Lerp (pos.x, firstLaneXPos + laneWidth * laneNumber, Time.deltaTime * speed);
		transform.position = pos;
	}
}
