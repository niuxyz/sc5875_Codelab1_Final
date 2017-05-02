using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickonAni : MonoBehaviour {
	private Ray ray;
	private RaycastHit hit;

	public GameObject animals;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Input.GetMouseButtonDown (0) && Physics.Raycast (ray, out hit) && hit.collider.tag == "Animal") {
			Debug.Log (hit.collider.gameObject.GetComponent<Animal>().Speak ());
			animals = hit.collider.gameObject;
		}		
	}
}
