using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CityEntrance : MonoBehaviour {
    public GameObject hawker;//行商人オブジェクトを定義
    private GameObject obj;
    public GameObject entrance;

    public static GameObject target;
    private int num = 5;//行商人の数

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (num >= 0)
        {
            obj=Instantiate(hawker, this.transform.position, Quaternion.identity);//行商人を生成
            obj.transform.parent = entrance.transform;
            num--;
        }
    }
}
