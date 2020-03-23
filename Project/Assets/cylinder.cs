using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinder : MonoBehaviour {

    public AudioSource tickSource;

	// Use this for initialization
	void Start () {
        tickSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter (Collision collision)
    {
        tickSource.Play();
    }
}
