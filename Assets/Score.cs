using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void task(){
		TextMesh myText = GetComponent<TextMesh> ();
		String  a=myText.text.ToString();
		int x = Convert.ToInt32 (a);
		x += 1;
		String str = x.ToString();
		myText.text = str;
		
	}

	public void penalty(){
		
			TextMesh myText = GetComponent<TextMesh> ();
			String  a=myText.text.ToString();
			int x = Convert.ToInt32 (a);
			x -=1;
			String str = x.ToString();
			myText.text = str;
		

}
}