using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hawkers : MonoBehaviour {

    //public Transform target;//移動先の街
    public float speed = 0.1f;//移動スピード
    public Transform parent;
	// Use this for initialization
	void Start () {
        parent= this.transform.parent;
    }

    // Update is called once per frame
    void Update () {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(parent.position - transform.position), 0.3f);
        transform.position += transform.forward * speed;
    }
}
