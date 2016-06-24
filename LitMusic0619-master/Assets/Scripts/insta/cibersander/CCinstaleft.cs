using UnityEngine;
using System.Collections;

public class CCinstaleft : MonoBehaviour {

	//曲のタイミングデータを宣言
	float[] timing=  {
		2.483403f,
		2.731451f,
		5.696881f,
		9.10961f,
		10.79941f,
		11.24671f,
		11.67753f,
		11.84311f,
		12.07616f,
		12.45691f,
		14.14704f,
		14.56089f,
		14.99204f,
		15.78683f,
		19.11675f,
		22.34726f,
		24.05365f,
		24.50095f,
		24.93168f,
		25.72689f,
		27.36699f,
		29.0071f,
		30.64722f,
		32.27075f,
		33.9937f,
		35.66724f,
		37.27392f,
		38.9803f,
		40.60386f,
		42.29368f,
		43.90169f,
		45.55736f,
		47.21405f,
		48.88732f,
		50.52773f,
		52.23383f,
		53.87394f,
		55.48092f,
		57.15425f,
		58.81087f,
		5.760553f,
		9.07388f,
		10.82994f,
		11.26068f,
		11.6417f,
		12.05587f,
		12.45529f,
		15.76863f,
		19.10143f,
		22.36277f,
		25.72581f,
		27.38248f,
		29.03931f,
		30.71242f,
		32.33596f,
		33.97609f,
		35.66591f,
		37.28947f,
		38.96271f,
		40.61938f,
		42.24294f,
		43.89961f,
		45.58942f,
		48.91994f,
		52.23274f,
		55.47984f,
		58.85956f,

		};
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
	Vector3 placePosition = new Vector3(-0.503f, 4.8f, 0.28f);
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



