using UnityEngine;
using System.Collections;

public class Renascer : MonoBehaviour {

	public Vector2 posicao;

	void Start(){
		posicao = transform.position;
	}

	public void Restaurar(){
		transform.position = posicao;
		GetComponent<Coracoes> ().coracoes = GetComponent<Coracoes> ().coracoesMax;
		GetComponent<Morrer> ().estaMorto = false;
		GetComponent<Controlador> ().Desparalizar ();
		GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
	}
}
