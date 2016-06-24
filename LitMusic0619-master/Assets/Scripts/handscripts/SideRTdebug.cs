using UnityEngine;
using System.Collections;

public class SideRTdebug : MonoBehaviour {


	public GameObject sideRTbar;

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
		sideRTbar.SendMessage ("flaggerRT");
		//ScoreScript.EnemyCount = 0;
	}
}

}
