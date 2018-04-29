using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Symbol : System.IEquatable<Symbol> {

	public static Symbol EPSILON = new Symbol("");

	private string value; 

	public Symbol(string value){
		if (value == "") {
			this.value = "EPSILON";
		} else {
			this.value = value;
		}
	}

	public string GetValue() {
		return value;
	}

	public bool Equals(Symbol other) {
		//Debug.Log ("Comparing: " + this.value + " " + other.GetValue ());
		return this.value == other.GetValue();
	}
}
