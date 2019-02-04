using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CityEntrance : MonoBehaviour {
    public GameObject hawker;//行商人オブジェクトを定義
    //private GameObject obj;
    public GameObject entrance;
    //public float timeout=60f;
    //private float timeElapsed;

    public static GameObject target;
    private int num = 5;//行商人の数

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // timeElapsed += Time.deltaTime;
        //if (timeElapsed >= timeout)
        //{
        num = popuManage(num);
           // timeElapsed = 0.0f;
        //}
    }
    public int popuManage (int x)
    {
        if (x <= 0) return 0;
        GameObject obj = Instantiate(hawker, new Vector3(this.transform.position.x,this.transform.position.y+5,this.transform.position.z), Quaternion.identity);//行商人を生成
        obj.transform.parent = entrance.transform;
        obj.transform.localScale = Vector3.one;
        x--;
        return x;
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "NPC")
        {
            Destroy(other.gameObject);
            num++;
        }
    }

}
