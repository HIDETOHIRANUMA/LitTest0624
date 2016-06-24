using UnityEngine;
using System.Collections;

public class MRightdebug : MonoBehaviour {

	public GameObject MRightbar;

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
			MRightbar.SendMessage ("flaggerMR");
		//ScoreScript.EnemyCount = 0;
	}
}

}
