using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogBubble : MonoBehaviour {
	[SerializeField] float SingingTime = 1.0f;
	private float timer;
	private bool IfAppear;
	private Color textColor;

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
			if (timer >= SingingTime) {
				TurnOff_Bubble ();
			}
		}
	}

	public void TurnOn_Bubble(){
		IfAppear = true;
		GetComponent<Image> ().color = Color.white;
		GetComponentInChildren<Text> ().enabled = true;
		timer = 0.0f;
	}


	public void TurnOff_Bubble(){
		timer = 0.0f;
		IfAppear = false;
		GetComponent<Image> ().color = Color.clear;
		GetComponentInChildren<Text> ().enabled = false;


	}
}
