using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sector : MonoBehaviour {
    public static bool isEnabled = false;

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void enableSector() {
        isEnabled = true;
    }
}
