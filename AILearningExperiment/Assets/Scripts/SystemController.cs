using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemController : MonoBehaviour {

	private State c,q0;
	public List<Symbol> Sigma;
	public List<Symbol> active;

	public OutputHandler output;

	// Use this for initialization
	void Start () {
		Sigma = new List<Symbol> ();
		active = new List<Symbol> ();
		q0 = new State ("q"+output.GetTransitionCount());
		c = q0;
		output.IncrementStateCount ();
	}
	
	// Update is called once per frame
	void Update () {
		output.ListStimuli (active);
	}

	public void HandleInput(string input) {
		string input_on = input;// + "_on";
		string input_off = input + "_off";
		Symbol s_on = new Symbol (input_on);
		Symbol s_off = new Symbol (input_off);
		if (Sigma.Contains (s_on)) {
			if (active.Contains (s_on)) {
				Debug.Log (s_off.GetValue ());
				active.Remove (s_on);
			} else {
				Debug.Log (s_on.GetValue ());
				active.Add (s_on);
			}
		} else {
			Debug.Log (s_on.GetValue ());
			active.Add (s_on);
			Sigma.Add (s_on);
		}
	}

	public void HandleTimeOut () {
		Debug.Log ("It's been a while since the last symbol was input");
	}

	private State delta(State q, Symbol a) {

	}
}
