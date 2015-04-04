using UnityEngine;
using System.Collections;

public class Andar : MonoBehaviour {

	public float h;
	public float velocidade;

	private bool colidindo;

	void Start () {
	
	}

	void Update () {
		h = Input.GetAxis ("Horizontal");
		h = h * Time.deltaTime;
		transform.Translate (h * velocidade, 0, 0);
	}
}		
