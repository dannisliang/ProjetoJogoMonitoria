using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {
	public Transform jogador;
	public Vector3 deslocamento, posIni;
	public Vector2 divisao;

	void Start(){
		jogador = GameObject.Find ("Jogador/Corpo").transform;
		posIni = transform.position;
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(jogador.position.x, posIni.y + (posIni.y  - jogador.position.y/divisao.y), jogador.position.z) + deslocamento;
		GetComponent<Renderer> ().material.SetTextureOffset("_MainTex", new Vector2 (-(posIni.x + (posIni.x  - jogador.position.x/divisao.x)), 0));
	}
}
