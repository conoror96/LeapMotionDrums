﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicators : MonoBehaviour {
    /*
    This script is used for creating and moving the blocks spawned for the drum hero game mode 
    It implements the iTween Unity plugin for animation
    */
    public GameObject prefab;
    public string notation;

    public float nextPlayTime;
    public int currentNote;
   
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (notation.Length == 0) return;
        if (Time.time > nextPlayTime)
        {
            nextPlayTime = Time.time + SpeedController.Instance.speed;
            if(notation.Substring(currentNote,1) != "0")
            {
                CreateNote(notation.Substring(currentNote, 1));
            }
            currentNote++;
            if (currentNote >= notation.Length) currentNote = 0;
        }
    }
   
    void CreateNote(string hand)
    {
        GameObject tempGO = Instantiate(prefab, transform);
        tempGO.transform.localPosition = new Vector3(0,0,5);
        iTween.MoveTo(tempGO, iTween.Hash("position", new Vector3(0,0,0), "time", 2f, "easeType", iTween.EaseType.linear, "isLocal", true));
        Destroy(tempGO, 2f);
    }

   
}
