using UnityEngine;
using System.Collections;

public class CameraSeguirJogador : MonoBehaviour {
	public Transform jogadorAlvo;
	public float zoom = 3.0f;
	public float altura = 3.0f;
	public float deslocamento = 0.0f;
	public float velocidade = 5.0f;

	
	void FixedUpdate () {
		jogadorAlvo = GameObject.Find ("Jogador/Corpo").transform;
		Vector3 posicaoFinal = jogadorAlvo.TransformPoint(deslocamento, altura, -zoom);
		if (!jogadorAlvo.GetComponent<Morrer> ().estaMorto) {
			transform.position = Vector3.Lerp (transform.position, posicaoFinal, Time.deltaTime * velocidade);
		}
	}
}