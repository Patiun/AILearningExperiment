using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour {

	private State originatingState;
	private State targetState;
	private float probability;

	public Transition(State startState, State endState) {
		originatingState = startState;
		targetState = endState;
	}

	public State GetOriginatingState() {
		return originatingState;
	}

	public State GetTargetState() {
		return targetState;
	}
}
