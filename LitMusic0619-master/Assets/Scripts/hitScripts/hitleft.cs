﻿using UnityEngine;
using System.Collections;

public class hitleft : MonoBehaviour {

	int flag=0;
	int Nextflag=0;
	public GameObject leftEffect;


	//配置する座標を設定
	Vector3 placePosition = new Vector3(-0.4871169f,-0.775f, -0.166f);
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
				//Instantiate (leftEffect,placePosition,q);
				GameObject objL= Instantiate(leftEffect,placePosition,q) as GameObject;
				Destroy(objL,0.5f);
				Destroy (other.gameObject);
				comboCounter.combo += 1;
				Nextflag = 0;
				flag = 0;
				//Destroy (gameObject.tag=="effect", 0.5f);
			}
			//ScoreScript.EnemyCount = 0;
		}


	}

	void flaggerleft(){
		flag = 1;
	}
}
