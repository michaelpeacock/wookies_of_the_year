using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssembleDrones : MonoBehaviour {

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void click(){
        Drone1LiveFeed.enableFeed();
        Drone2LiveFeed.enableFeed();
        Drone3LiveFeed.enableFeed();
        Drone4LiveFeed.enableFeed();
    }
}
