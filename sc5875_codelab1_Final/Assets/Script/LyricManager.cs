using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LyricManager : MonoBehaviour {
	[SerializeField] List<string> LyricsOrder;
	[SerializeField] List<float> Nodes;
	[SerializeField] float WholeSong;
	[SerializeField] AudioClip Song;
	private AudioSource audioSource;
	private float timer;


	// Use this for initialization
	void Start () {
		timer = 0.0f;
		WholeSong = Song.length;
		audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = Song;
		audioSource.loop = false;
		audioSource.Play();
	}
	
	// Update is called once per frame
	void Update () {
		// timer += Time.deltaTime;
		// if (timer >= WholeSong) {
		// 	timer = 0.0f;
		// }
		if(timer <= WholeSong){
			timer += Time.deltaTime;
		}
	}

	private int Get_Current_Section()
	{
		for (int i = 0; i < Nodes.Count; i++) {
			if (timer <= Nodes [i]) {
				return i;
			}
		}
		return (Nodes.Count);
	}

	public string Get_Current_Lyrics() {
		return LyricsOrder [Get_Current_Section()];
	}
	public bool ifSoundEnd(){
		return timer > WholeSong;
	}
}
