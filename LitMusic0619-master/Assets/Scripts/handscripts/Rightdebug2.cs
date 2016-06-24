using UnityEngine;
using System.Collections;

public class Rightdebug2 : MonoBehaviour {

	public GameObject rightbar;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}


	
	void OnTriggerEnter(Collider collider){  
	if (collider.gameObject.tag=="hand") {
		//touch.Play ();
		//other.gameObject.SendMessage ("PlayerDamage");
		rightbar.SendMessage ("flaggerRight");
		//ScoreScript.EnemyCount = 0;
	}
}

}
