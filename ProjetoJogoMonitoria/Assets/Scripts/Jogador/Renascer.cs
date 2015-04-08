using UnityEngine;
using System.Collections;

public class Renascer : MonoBehaviour {

	public Vector2 posiçao;

	void Start(){
		posiçao = transform.position;
	}

	public void Restaurar(){
		transform.position = posiçao;
		GetComponent<Coraçoes> ().coraçoes = GetComponent<Coraçoes> ().coraçoesMax;
		GetComponent<Morrer> ().estaMorto = false;
		GetComponent<Controlador> ().Desparalizar ();
	}
}
