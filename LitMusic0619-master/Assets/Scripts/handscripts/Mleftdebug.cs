using UnityEngine;
using System.Collections;

public class Mleftdebug : MonoBehaviour {

	public GameObject Mleftbar;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}
			
	void OnTriggerEnter(Collider collider)
	{  
	if (collider.gameObject.tag=="hand") {
		//touch.Play ();
		//other.gameObject.SendMessage ("PlayerDamage");
		Mleftbar.SendMessage ("flaggerMleft");
		//ScoreScript.EnemyCount = 0;
		}
	}

}
