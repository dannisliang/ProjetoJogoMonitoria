using UnityEngine;
using System.Collections;

public class SofrerDano : MonoBehaviour {

	public bool estaInvulneravel;
	public float tempoInvulnerabilidade;
	public float tempoInvulnerabilidadeMax;
	public float intervaloPiscar;
	public float intervaloPiscarMax;

	void Update () {
		if (estaInvulneravel) {
			intervaloPiscar += Time.deltaTime;
			if(intervaloPiscar >= intervaloPiscarMax){
				intervaloPiscar = 0;
				if(GetComponent<SpriteRenderer>().enabled == true){
					GetComponent<SpriteRenderer>().enabled = false;
				}
				else{
					GetComponent<SpriteRenderer>().enabled = true;
				}
			}

			tempoInvulnerabilidade += Time.deltaTime;

		}
		if (tempoInvulnerabilidade >= tempoInvulnerabilidadeMax) {
			estaInvulneravel = false;
			tempoInvulnerabilidade = 0;
			GetComponent<SpriteRenderer>().enabled = true;
			GetComponent<Controlador> ().Desparalizar ();
		}
	}

	public void aplicarDano( int dano, float forçaEmpurrao, float inimigoPosX){
		estaInvulneravel = true;
		GetComponent<Coraçoes> ().coraçoes -= dano;
		if (inimigoPosX < transform.position.x) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (forçaEmpurrao, 0);
		} else {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-1 * forçaEmpurrao, 0);
		}
		GetComponent<Controlador> ().Paralizar ();
	}

	public void aplicarDano(int dano){
		estaInvulneravel = true;
		GetComponent<Coraçoes> ().coraçoes -= dano;
		GetComponent<Controlador> ().Paralizar ();
	}


}
