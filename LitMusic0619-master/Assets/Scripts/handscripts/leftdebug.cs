using UnityEngine;
using System.Collections;

public class leftdebug : MonoBehaviour {

	//public GameObject Lefthand;
	//public GameObject Righthand;
	public GameObject leftbar;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}

		
	void OnTriggerEnter(Collider collider){  
		if (collider.gameObject.tag == "hand") {
			//touch.Play ();
			//other.gameObject.SendMessage ("PlayerDamage");
			leftbar.SendMessage ("flaggerleft");
			//ScoreScript.EnemyCount = 0;
		}
	}

}
