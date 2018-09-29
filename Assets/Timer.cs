using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
	public float value;
	public GameObject g1;
	public GameObject g2;

	// Use this for initialization
	void Start () {
		GetComponent<TextMesh> ().text = value.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		value -= Time.deltaTime;
		GetComponent<TextMesh> ().text = value.ToString();
		if (value <= 0) {
			GetComponent<TextMesh> ().text = "TIME UP";
			DisableAll ();
			EnableRestart();
		}

	}
	void DisableAll(){
		 GameObject[] asr=GameObject.FindGameObjectsWithTag("RED");
		 GameObject[] asr2=GameObject.FindGameObjectsWithTag("YELLOW");
		foreach( GameObject go in asr){
			go.SetActive(false);
	}
		foreach( GameObject go in asr2){
			go.SetActive(false);
		}


}
	void EnableRestart(){
		GameObject[] asr = GameObject.FindGameObjectsWithTag ("Restart");
		foreach(GameObject go in asr){
			go.SetActive (true);

	}
}
}