using UnityEngine;
using System.Collections;

public class Andar : MonoBehaviour {

	public float h;
	public float velocidade;
	void Start () {
	
	}

	void Update () {
		h = Input.GetAxis ("Horizontal");
		h = h * Time.deltaTime;
		transform.Translate(new Vector3(h * velocidade, 0,0));
	}

}
