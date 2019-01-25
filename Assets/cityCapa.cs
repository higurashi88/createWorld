using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cityCapa : MonoBehaviour {
    public GameObject hawker;
    public GameObject city;
    public static Transform target;

    public float develop = 100f;//町の発展度
    public int popu;//町の人口
    //public static Vector3 mati; 

	// Use this for initialization
	void Start () {
        //mati = target.transform.position;
        target = city.transform;
	}
	
	// Update is called once per frame
	void Update () {
        if (0 < popu)
        {
            Instantiate(hawker,this.transform.position,Quaternion.identity);
            popu--;
        } 
	}
   
}
