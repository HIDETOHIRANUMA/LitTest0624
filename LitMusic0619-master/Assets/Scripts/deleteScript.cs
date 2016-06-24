using UnityEngine;
using System.Collections;

public class deleteScript : MonoBehaviour {
	public GameObject ComboCounter;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/*void OnTriggerEnter(Collision other){
		Destroy (other.gameObject);

}*/

	void OnTriggerEnter(Collider other){
		
		Destroy (other.gameObject);
		comboCounter.combo = 0;
	}
			
		
	

}