using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fox : Animal {

	public override string Speak(){
		base.Speak ();
		return "...";
	}
}
