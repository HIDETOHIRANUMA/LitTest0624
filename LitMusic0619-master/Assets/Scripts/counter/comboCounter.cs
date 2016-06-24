using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class comboCounter : MonoBehaviour {
	
	//int comboflag=0;
	public static int combo=0;//コンボ数
	public Text scoreLabel; //UIテキスト

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		scoreLabel.text = "Combo:"+combo.ToString();
	}


}
