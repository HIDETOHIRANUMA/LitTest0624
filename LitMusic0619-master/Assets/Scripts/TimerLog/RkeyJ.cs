using UnityEngine;
using System.Net.Sockets;
using System.Text;
using UnityEngine.VR;
using System;
using System.IO;


public class RkeyJ : MonoBehaviour
{
	float timer = 0.0f;

	//書き込み準備
	StreamWriter sw;
	FileInfo fi;

	void Start ()
	{
		//ファイル準備
		fi = new FileInfo(Application.dataPath + "/TimeLogRigh.csv");
		sw = fi.AppendText();

	}


	void Update ()
	{
		timer = timer + Time.deltaTime;

		if (Input.GetKeyDown (KeyCode.J)) { 

			//Debug.Log (timer);
			//sound01.PlayOneShot(sound01.wav); //記録時にサウンドをやりたかった　修正してください
			sw.WriteLine (timer);
		}
		if (Input.GetKeyDown (KeyCode.Escape)) {
			sw.Flush ();
			sw.Close ();
			Debug.Log ("書き込みしました");
		}

	}



}

