using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mrgizz : Animal {
	[SerializeField] int FontSize = 20;
	public override string Speak(){
		base.Speak ();
		ChangeFontSize(FontSize);
		return "...";
	}
}
