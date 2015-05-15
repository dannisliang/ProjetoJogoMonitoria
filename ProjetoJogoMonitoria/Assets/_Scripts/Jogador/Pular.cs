using UnityEngine;
using System.Collections;

public class Pular : MonoBehaviour {

	public float velocidade;
	public float velocidadeInicial;
	public float desaceleracao;
	public int pulosNoAr;
	public int pulosNoArMax;
	public bool estaPulando;
	public bool estaPulandoNoAr;
	public bool caindo;


	void Update () {



		if (Input.GetButtonUp ("Jump")) {
			FinalizarPulo();
		}

		if (GetComponent<ChecarColisao> ().estaNoChao) {
			pulosNoAr = 0;
			caindo = false;
		} else {
			if(!estaPulandoNoAr && !estaPulando){
				caindo = true;
			}
		}

		if(Input.GetButtonDown("Jump")){
			if (GetComponent<ChecarColisao>().estaNoChao) {
				estaPulando = true;
				estaPulandoNoAr = false;
			}
			else{
				if(pulosNoAr < pulosNoArMax){
					estaPulandoNoAr = true;
					pulosNoAr++;
				}
				else{
					estaPulandoNoAr = false;
				}
				estaPulando = false;
			}
		}


		if ((estaPulando || estaPulandoNoAr) && velocidade >= 0) {
			IniciarPulo();
		} else {
			FinalizarPulo();
		}
	}

	public void IniciarPulo(){
		GetComponent<Rigidbody2D>().gravityScale = 0;
		GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		velocidade -= desaceleracao*Time.deltaTime;
		transform.Translate (new Vector3 (0, velocidade * Time.deltaTime, 0));
	}

	public void FinalizarPulo(){
		GetComponent<Rigidbody2D>().gravityScale = 1;
		velocidade = velocidadeInicial;
		estaPulandoNoAr = false;
		estaPulando = false;
	}
	
}
