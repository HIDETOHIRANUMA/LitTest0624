using UnityEngine;
using System.Net.Sockets;
using System.Text;
using UnityEngine.VR;
using System;
using System.IO;


public class test11 : MonoBehaviour
{
	float timer = 0.0f;

	//書き込み準備
	StreamWriter sw;
	FileInfo fi;

	void Start ()
	{
		//ファイル準備
		fi = new FileInfo(Application.dataPath + "/Bugtest2.csv");
		sw = fi.AppendText();

	}


	void Update ()
	{
		timer = timer + Time.deltaTime;

		if (Input.GetKeyDown (KeyCode.T)) { 

			//Debug.Log (timer);
			sw.WriteLine (timer);
		}
		if (Input.GetKeyDown (KeyCode.Escape)) {
			sw.Flush ();
			sw.Close ();
			Debug.Log ("書き込みしました");
		}

	}



}

