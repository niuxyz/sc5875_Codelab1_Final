using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal : MonoBehaviour {
	[SerializeField] protected Color TextColor;
	protected LyricManager _lyricManager;
	public Text SpeakText;

	void Start(){
		_lyricManager = GameObject.Find ("LyricManager").GetComponent<LyricManager>();
	}

	public virtual string Speak (){
		SpeakText.color = TextColor;
		SpeakText.text = _lyricManager.Get_Current_Lyrics();
		SpeakText.transform.parent.GetComponent<DialogBubble> ().TurnOn_Bubble ();
		return _lyricManager.Get_Current_Lyrics();
	}

	protected void ChangeFontSize(int _FontSize){
		SpeakText.fontSize = _FontSize;
	}
}
