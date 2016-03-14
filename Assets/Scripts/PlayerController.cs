using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public Player Player1;
	public Player Player2;

	void Start () {
		
	}

	void Update () {
		Player1.Move (Input.GetAxisRaw ("Horizontal"));
		Player2.Move (Input.GetAxisRaw ("Vertical"));
	}
}
