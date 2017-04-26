using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fox : Animal {
	public Text Foxtalk1;

	//	// Use this for initialization
//	void Start () {
//		
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		
//	}

	public override string Speak(){
		Foxtalk1.text = "die kevin!";
		return "die kevin!";
	}
}
