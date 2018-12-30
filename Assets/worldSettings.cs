using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldSettings : MonoBehaviour {
    public int WorldMagic=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        WorldMagic += 10;
	}
}
