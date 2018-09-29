using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class YellowFunctions : MonoBehaviour {
	
	public GameObject toDestroy;
	public float Value;

	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * Value * Time.deltaTime); 
	}


	public void Dest()
	{	
		toDestroy.SetActive(false);



	}

}

