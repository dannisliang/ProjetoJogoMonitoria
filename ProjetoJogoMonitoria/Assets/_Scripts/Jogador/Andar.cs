using UnityEngine;
using System.Collections;

public class Andar : MonoBehaviour {

	public float h;
	public float velocidade;
	public bool direita;
	public bool esquerda;


	void Update () {
		h = Input.GetAxis ("Horizontal");
		transform.Translate (h * velocidade*Time.deltaTime, 0, 0);

	}
}		
