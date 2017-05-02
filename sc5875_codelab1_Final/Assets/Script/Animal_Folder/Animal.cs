using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal : MonoBehaviour {
	protected LyricManager _lyricManager;
	public Text SpeakText;

	void Start(){
		_lyricManager = GameObject.Find ("LyricManager").GetComponent<LyricManager>();
	}

	public virtual string Speak (){
		SpeakText.text = _lyricManager.Get_Current_Lyrics();
		SpeakText.transform.parent.GetComponent<DialogBubble> ().TurnOn_Bubble ();
		return _lyricManager.Get_Current_Lyrics();
	}
}
