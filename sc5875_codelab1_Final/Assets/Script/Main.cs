using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour {
	[SerializeField] GameObject blackScreen_Canvas;
	private Image blackScreen_Image;
	private float fadeout;
	private LyricManager _lyricManager;
	void Start () {
		_lyricManager = GameObject.Find("LyricManager").GetComponent<LyricManager>();
		blackScreen_Image = blackScreen_Canvas.GetComponentInChildren<Image>();

	}
	void Update(){
		if(_lyricManager.ifSoundEnd() == true){
			fadeout += Time.deltaTime;
			blackScreen_Image.color = Color.Lerp(Color.clear, Color.black, fadeout);
		}
	}

}
