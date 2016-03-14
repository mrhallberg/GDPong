using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed;
	public float length;

	float maxY;
	float minY;

	void Start () {
		maxY = Camera.main.ViewportToWorldPoint (new Vector3 (1, 1, 0)).y;
		minY = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, 0)).y;
		Debug.Log (maxY + ", " + minY);
	}

	void Update () {
	
	}

	public void Move(float y){
		if (y > 0 && !(transform.position.y + length/2 > maxY)) {
			transform.position += Vector3.up * y * speed;
		}
		if (y < 0 && !(transform.position.y - length/2 < minY)) {
			transform.position += Vector3.up * y * speed;
		}
	}
}
