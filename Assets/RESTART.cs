using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RESTART : MonoBehaviour {

	// Use this for initialization

	
	// Update is called once per frame
	public void renew () {
		ASD ();
	}
	void ASD(){
		GameObject[] asr=GameObject.FindGameObjectsWithTag("RED");
		GameObject[] asr2=GameObject.FindGameObjectsWithTag("YELLOW");
		foreach( GameObject go in asr){
			go.SetActive (true);
		}
		foreach( GameObject go in asr2){
			go.SetActive (true);
		}
	}
}
