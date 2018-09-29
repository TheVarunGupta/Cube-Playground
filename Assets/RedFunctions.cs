using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RedFunctions : MonoBehaviour {
	public float Value=90;

	public GameObject toDestroy;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * Value * Time.deltaTime); 
	}
	public void flipSpin(){
		Value = -Value;
	}

	public void Destroy()
	{
		toDestroy.SetActive(false);
	}
}
