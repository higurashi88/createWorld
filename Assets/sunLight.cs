using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class sunLight : MonoBehaviour {
    [SerializeField]
    private float sunSpeed=0.1f;
    [SerializeField]
    private Vector3 rotation = new Vector3(270f, 330f, 0f);
	// Use this for initialization
	void Start () {
        transform.localRotation = Quaternion.Euler(rotation);

        var rotX = transform.localEulerAngles.x - 15f * DateTime.Now.Hour;
        if(rotX < 0)
        {
            rotX += 360;
        }
        transform.localEulerAngles = new Vector3(rotX, transform.localEulerAngles.y, transform.localEulerAngles.z);

	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(-Vector3.right * sunSpeed * Time.deltaTime);
	}
}
