using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LyricManager : MonoBehaviour {
	[SerializeField] List<string> LyricsOrder;
	[SerializeField] List<float> Section;
	[SerializeField] float WholeSong;
	[SerializeField] AudioClip Song;
	private float timer;


	// Use this for initialization
	void Start () {
		timer = 0.0f;
		//WholeSong = Song.length;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= WholeSong) {
			timer = 0.0f;
		}
	}

	private int Get_Current_Section()
	{
		for (int i = 0; i < Section.Count; i++) {
			if (timer <= Section [i]) {
				return i;
			}
		}
		return (Section.Count-1);
	}

	public string Get_Current_Lyrics() {
		return LyricsOrder [Get_Current_Section()];
	}
}
