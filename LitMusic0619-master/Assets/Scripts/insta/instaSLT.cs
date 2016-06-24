using UnityEngine;
using System.Collections;

public class instaSLT : MonoBehaviour {

	//曲のタイミングデータを宣言
	float[] timing=  {1.5f,2.2f,2.5f,2.9f,3.6f,4.3f,4.7f,5.1f,5.4f,5.8f,6.5f,7.2f,7.8f,8.3f,8.7f,9.2f,9.8f,10.1f,10.7f,11.2f,11.6f,11.7f,11.978f,12.1f,12,3f,100f};
	int i=0;


	//曲の判定結果を格納しておく変数を宣言。
	public static int cool; public static int good; public static int bad;

	//エフェクトを格納。
	public GameObject goodEffect;
	public GameObject badEffect;
	public GameObject copybar;

	// Use this for initialization
	void Start () {
		
		cool = 0; good = 0;bad = 0;

	}

    //配置する座標を設定
	Vector3 placePosition = new Vector3(-2.485117f, 4.8f, 0.28f);
    //配置する回転角を設定
    Quaternion q = new Quaternion(0,0,0,0);
   

    float timer=0.0f;
	// Update is called once per frame
	void Update () {
		
		timer = timer + Time.deltaTime;

               
        if (timing[i] <= timer)
        {
            Instantiate(copybar,placePosition,q);
            i++;
        }
    }

}



