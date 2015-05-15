using UnityEngine;
using System.Collections;

public class PassarDeFase : MonoBehaviour {
	public float tempoParaRecomecar;
	public float tempoParaRecomecarMax;
	public bool passouDeFase;
	public GUIStyle style;
	public Transform jogador;
	public Vector3 posicao;
	public bool podeApertarTecla;
	

	void Update(){
		if (passouDeFase) {
			tempoParaRecomecar += Time.deltaTime;
			jogador.position = posicao;
			if (tempoParaRecomecar >= tempoParaRecomecarMax) {
				tempoParaRecomecar = 0;
				podeApertarTecla = true;
			}
			if(Input.anyKeyDown){
				Application.LoadLevel (Application.loadedLevel);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D outro){
		if (outro.name == "ColisorCorpo") {
			passouDeFase = true;
			jogador = outro.transform.parent;
			posicao = jogador.position;
			jogador.GetComponent<Animacoes>().enabled = false;
			jogador.GetComponent<Rigidbody2D>().gravityScale = 0;
			jogador.GetComponent<Animator>().speed = 0;
			jogador.GetComponent<Controlador>().Paralizar();

		}
	}

	void OnGUI(){
		if (passouDeFase) {
			GUI.Label (new Rect (0, 0, Screen.width, Screen.height / 2), "PARABÉNS!\nNível Concluido!", style);
		}
		if (podeApertarTecla) {
			GUI.Label (new Rect (0, 0, Screen.width, Screen.height / 2), "\n\n\nAperte qualquer tecla para recomeçar.", style);
		}
	}
}
