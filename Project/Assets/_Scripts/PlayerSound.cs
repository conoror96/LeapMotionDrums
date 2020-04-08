using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour {
   /*
   This script plays the drum sound when the user interacts with the colliders on the drums
   It also changes the pitch of the drums by a random range between two values
   */
    public AudioSource source;
	
	void Start () {
        source = GetComponent<AudioSource>();
	}
	
	public void OnTriggerEnter(Collider other)
    {
        // changes the audio pitch of drums each time their hit
        source.pitch = Random.Range(0.8f, 1.2f);
        source.Play();
    }

    public void GesturePlay()
    {
        // changes the audio pitch of drums each time their hit
        source.pitch = Random.Range(0.8f, 1.2f);
        source.Play();
    }
}
