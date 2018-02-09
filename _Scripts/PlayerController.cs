using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D rb;


	void FixedUpdate () {

		rb = GetComponent <Rigidbody2D> ();

		float x = Input.GetAxis ("Horizontal");
		float y = Input.GetAxis ("Vertical");

	
		rb.position = rb.position + new Vector2 (x, 0f);

	}
}
