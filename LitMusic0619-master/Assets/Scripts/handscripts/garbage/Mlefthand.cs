using UnityEngine;
using System.Collections;

public class Mlefthand : MonoBehaviour {

	public GameObject Lefthand;
	public GameObject Righthand;
	public GameObject Mleftbar;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}

	void OnTriggerStay(Collider other){
		if (other.gameObject.tag=="triggerbutton") {
			//touch.Play ();
			//other.gameObject.SendMessage ("PlayerDamage");
			Debug.Log("手が当たりました");
			Mleftbar.SendMessage ("flaggerMleft");
			//ScoreScript.EnemyCount = 0;
		}


	}
}
