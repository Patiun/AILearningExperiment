using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	public float timeSinceLastSymbol; //In seconds
	public float tau; //In seconds

	public List<State> Q;
	public State c,q0,q1,qa;

	public Symbol al,ol;

	// Use this for initialization
	void Start () {
		Q = new List<State> ();
		timeSinceLastSymbol = 0;

		//Step 1
		c = q0;
		q1 = q0;

		al = Symbol.EPSILON;
		ol = Symbol.EPSILON;
	}
	
	// Update is called once per frame
	void Update () {
		timeSinceLastSymbol += Time.deltaTime;
		if (timeSinceLastSymbol > tau) {
			Debug.Log ("Time has passed");
			State qd = delta (c, Symbol.EPSILON);
			if (qd != null) {
				if (qd.IsTemporary ()) {
					qd.MarkPermanent ();
				}
				q1 = c;
				c = qd;
			}
			qa = c;
			al = Symbol.EPSILON;
			ol = Symbol.EPSILON;
			//Unmark all symbols o and distributions of P of Delta taking q and alpha
			//Go to step 2?

			timeSinceLastSymbol = 0.0f;
		}
	}

	private State delta(State q, Symbol a){
		//TODO
		return null;
	}

	private void CreateNewTransition(){
		State qd = delta (c, Symbol.EPSILON);
		if (qd != null && qd.IsTemporary ()) {
			Q.Remove (qd); //NO idea if this is right?
		}
	}
}
