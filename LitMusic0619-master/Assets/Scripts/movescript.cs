using UnityEngine;
using System.Collections;

public class movescript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(0f, -2f*Time.deltaTime, 0f);//距離5.909なので到着まで2.9545秒//聞く
	
	}
}
