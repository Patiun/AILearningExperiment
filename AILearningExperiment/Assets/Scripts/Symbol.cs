using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Symbol : MonoBehaviour {

	public static Symbol EPSILON = new Symbol("");

	private string value; 

	public Symbol(string value){
		this.value = value;
	}

	public string GetValue() {
		return value;
	}
}
