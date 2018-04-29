using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutputHandler : MonoBehaviour {

	public int stateCount,transitionCount;
	public Text statusField;
	public Text stimuliField;

	// Use this for initialization
	void Start () {
		stateCount = 0;
		transitionCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		statusField.text = "States: " + stateCount + " | Transitions: " + transitionCount;
	}

	public void ListStimuli(List<Symbol> stimuli) {
		string output = "Active Stimuli:\n";
		foreach (Symbol s in stimuli) {
			output = output + s.GetValue () + "\n";
		}
		stimuliField.text = output;
	}

	public void IncrementStateCount() {
		stateCount++;
	}

	public void IncrementTransitionCount() {
		transitionCount++;
	}

	public int GetStateCount() {
		return stateCount;
	}

	public int GetTransitionCount() {
		return transitionCount;
	}
}
