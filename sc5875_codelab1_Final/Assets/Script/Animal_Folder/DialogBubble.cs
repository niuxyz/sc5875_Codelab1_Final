using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogBubble : MonoBehaviour {
	private float timer;
	private bool IfAppear;

	// Use this for initialization
	void Start () {
		timer = 0.0f;
		IfAppear = false;
		GetComponent<Image> ().color = Color.clear;
		GetComponentInChildren<Text> ().color = Color.clear;
	}
	
	// Update is called once per frame
	void Update () {
		if (IfAppear == true) {
			timer += Time.deltaTime;
			if (timer >= 1.0f) {
				TurnOff_Bubble ();
			}
		}
	}

	public void TurnOn_Bubble(){
		IfAppear = true;
		GetComponent<Image> ().color = Color.white;
		GetComponentInChildren<Text> ().color = Color.black;
		timer = 0.0f;
	}


	public void TurnOff_Bubble(){
		timer = 0.0f;
		IfAppear = false;
		GetComponent<Image> ().color = Color.clear;
		GetComponentInChildren<Text> ().color = Color.clear;


	}
}
