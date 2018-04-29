using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour {

	private InputField field;
	private SystemController controller;
	public float timeSinceLastSymbol;
	public float tau;
	public bool isPaused;

	// Use this for initialization
	void Start () {
		field = GetComponent<InputField> ();
		controller = GameObject.FindGameObjectWithTag ("Controller").GetComponent<SystemController> ();
		timeSinceLastSymbol = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (!isPaused) {
			timeSinceLastSymbol += Time.deltaTime;
			if (timeSinceLastSymbol > tau) {
				controller.HandleTimeOut ();
				timeSinceLastSymbol = 0.0f;
			}
		}

		if (Input.GetKeyDown ("p") && !field.isFocused) {
			isPaused = !isPaused;
		}
	}

	public void GetInput(){
		if (!isPaused) {
			controller.HandleInput (field.text);
			field.text = "";
			timeSinceLastSymbol = 0.0f;
		}
	}
}
