using UnityEngine;
using System.Collections;

public class turnRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Rotate (0, 0.5f, 0);
	
	}
}
