using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA : MonoBehaviour {


	// each float represent gen for color
	public float r;
	public float g;
	public float b;

	// if person is clicked => dead true
	bool dead = false;
	// in order to track how long the person lived
	public float timeToDie = 0;
	SpriteRenderer sRenderer;
	Collider2D sCollider;

	// person is clicked
	void OnMouseDown(){
		dead = true;
		timeToDie = PopulationManager.elapsed;
		Debug.Log ("Dead At: " + timeToDie);
		sRenderer.enabled = false;
		sCollider.enabled = false;
	}
		
	void Start () {
		sRenderer = GetComponent<SpriteRenderer> ();
		sCollider = GetComponent<Collider2D> ();
		sRenderer.color = new Color (r, g, b);
	}

	void Update () {
		
	}
}
