using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cityCapa : MonoBehaviour {
    public GameObject hawker;
    public GameObject target;

    public float develop = 100f;//町の発展度
    public int popu;//町の人口

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (0 < popu)
        {
            Instantiate(hawker);
            popu--;
        } 
	}
}
