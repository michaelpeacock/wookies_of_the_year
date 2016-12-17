using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class Drone1LiveFeed : MonoBehaviour {
    public List<Texture2D> myTextures = new List<Texture2D>();
    int frame = 0;
    int delay = 0;
	// Use this for initialization
	void Start () {
        DirectoryInfo d = new DirectoryInfo(Application.dataPath + "/Images/Drone1");

        //var tex = new Texture2D(1,1, TextureFormat.Alpha8, false);
        FileInfo[] file = d.GetFiles("*.png");
        for (var i = 0;i < file.Length; ++i)
        {
            Debug.Log(file);
            WWW www = new WWW(@"file:///" + file[i].ToString());
            while (www.isDone == false)
            {
            }
            myTextures.Add(www.texture);
        }

        GetComponent<Renderer>().material.mainTexture = myTextures[frame];
        Debug.Log("Total count is" + myTextures.Count);
    }
	
	// Update is called once per frame
	void Update () {

        if (delay == 20)
        {
            if (frame == myTextures.Count)
            {
                frame = 0;
            }
            Debug.Log("Current frame is " + frame);
            GetComponent<Renderer>().material.mainTexture = myTextures[frame];

            frame = frame + 1;
            delay = 0;
        }
        delay++;
    }
}
