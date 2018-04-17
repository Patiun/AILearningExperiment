using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour {

	private string label;
	private bool isTemporary;
	private bool isPermanent;

	public State(string label) {
		this.label = label;
	}

	public string GetLabel() {
		return label;
	}

	public void MarkTemporary() {
		isTemporary = true;
	}

	public void MarkPermanent() {
		isTemporary = false;
		isPermanent = true;
	}

	public bool IsTemporary() {
		return isTemporary;
	}

	public bool IsPermanent() {
		return isPermanent;
	}
}
