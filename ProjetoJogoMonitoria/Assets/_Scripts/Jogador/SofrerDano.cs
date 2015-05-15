using UnityEngine;
using System.Collections;

public class SofrerDano : MonoBehaviour {

	public bool estaInvulneravel;
	public float tempoInvulnerabilidade;
	public float tempoInvulnerabilidadeMax;
	public float intervaloPiscar;
	public float intervaloPiscarMax;
	public bool piscar;

	void Update () {
		if (estaInvulneravel) {
			tempoInvulnerabilidade += Time.deltaTime;
			if(piscar){
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
			}
		}
		if (tempoInvulnerabilidade >= tempoInvulnerabilidadeMax) {
			estaInvulneravel = false;
			tempoInvulnerabilidade = 0;
			GetComponent<SpriteRenderer>().enabled = true;
			GetComponent<Controlador> ().Desparalizar ();
		}
	}

	public void aplicarDano( int dano, float forcaEmpurrao, float inimigoPosX){
		estaInvulneravel = true;
		GetComponent<Coracoes> ().coracoes -= dano;
		if (inimigoPosX < transform.position.x) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (forcaEmpurrao, 0);
		} else {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-1 * forcaEmpurrao, 0);
		}
		GetComponent<Controlador> ().Paralizar ();
	}

	public void aplicarDano(int dano){
		estaInvulneravel = true;
		GetComponent<Coracoes> ().coracoes -= dano;
		GetComponent<Controlador> ().Paralizar ();
	}


}
