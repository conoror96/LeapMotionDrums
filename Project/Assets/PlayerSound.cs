using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour {

    public AudioSource source;
	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
	}
	
	 void OnTriggerEnter(Collider other)
    {
        // if(other.tag == "DrumStickHead")
        //{
        // changes the audio pitch of drums each time their hit
        source.pitch = Random.Range(0.8f, 1.2f);
        // source.volume = other.gameObject.GetComponent<TrackSpeed>().speed;
        source.Play();
        //}
    }
}
