using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedController : MonoBehaviour {
    /*
    This script is used for changing the speed of the blocks  
    The speed can be changed in the speedController game controller in the scene objects.
    */
     
    public static SpeedController Instance;
    public float speed;
	// Use this for initialization
	void Awake () {
        if (Instance == null) Instance = GetComponent<SpeedController>();
	}
	
}
