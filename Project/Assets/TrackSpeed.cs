using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackSpeed : MonoBehaviour {

    private Vector3 lastPosition;
    public float speed;
	// Use this for initialization
	void Start () {
        lastPosition = transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        // Calculate the speed of the drum stick
		speed = (((transform.position = lastPosition).magnitude) / Time.deltaTime);
        lastPosition = transform.position;
	}
}
