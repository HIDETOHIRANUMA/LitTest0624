using UnityEngine;
using System.Collections;

public class SideLTdebug : MonoBehaviour {

	//public GameObject Lefthand;
	//public GameObject Righthand;
	public GameObject SideLTbar;

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
		SideLTbar.SendMessage ("flaggerLT");
		//ScoreScript.EnemyCount = 0;
	}
}

}
