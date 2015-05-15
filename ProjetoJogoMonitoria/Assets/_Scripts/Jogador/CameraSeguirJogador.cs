using UnityEngine;
using System.Collections;

public class CameraSeguirJogador : MonoBehaviour {
	public Transform jogadorAlvo;
	public float zoom;
	public float altura;
	public float deslocamento;
	public float velocidade;

	
	void Update () {
		jogadorAlvo = GameObject.Find ("Jogador/Corpo").transform;
		GetComponent<Camera> ().orthographicSize = zoom;
		Vector3 posicaoFinal = jogadorAlvo.TransformPoint(deslocamento, altura, -zoom);
		if (!jogadorAlvo.GetComponent<Morrer> ().estaMorto) {
			transform.position = Vector3.Lerp (transform.position, posicaoFinal, Time.deltaTime * velocidade);
		}
	}
}