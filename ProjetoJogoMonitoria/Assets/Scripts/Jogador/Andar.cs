using UnityEngine;
using System.Collections;

public class Andar : MonoBehaviour {

	public float h;
	public float velocidade;


	void FixedUpdate () {
		h = Input.GetAxis ("Horizontal");
		h = h * Time.deltaTime;
		transform.Translate (h * velocidade, 0, 0);
		//GetComponent<Rigidbody2D> ().velocity = new Vector2 (h * velocidade, GetComponent<Rigidbody2D> ().velocity.y);
	}
}		
