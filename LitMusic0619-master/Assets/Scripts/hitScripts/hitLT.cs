using UnityEngine;
using System.Collections;

public class hitLT : MonoBehaviour {
	
	int flag=0;
	int Nextflag=0;
	public GameObject LsideEffect;


	//配置する座標を設定
	Vector3 placePosition = new Vector3(-2.485f, -0.675f, -0.47f);
	//配置する回転角を設定
	Quaternion q = new Quaternion(0,0,0,0);

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (flag == 1) {
			Nextflag = 1;
		}


	}
	void OnTriggerStay(Collider other){
		if (Nextflag==1) {

			if (other.tag == "Copybar") {
				//GameObject obj=Instantiate (sideEffect,placePosition,q);
				GameObject objLT = Instantiate(LsideEffect,placePosition,q) as GameObject;
				Destroy (other.gameObject);
				comboCounter.combo += 1;
				Nextflag = 0;
				flag = 0;
				Destroy(objLT,0.5f);
			}
			//ScoreScript.EnemyCount = 0;
		}


	}

	void flaggerLT(){
		flag = 1;
	}
}

