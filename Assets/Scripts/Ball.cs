using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {


	public float speed;

	Rigidbody2D rigidbody;

	void Start () {
		rigidbody = GetComponent<Rigidbody2D> ();
		rigidbody.AddForce (Vector2.one * speed);
	}

	void Update () {
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.collider.tag == "Player") {
			rigidbody.Sleep ();
			rigidbody.AddForce (Vector2.one * speed);
		}
	}
}
