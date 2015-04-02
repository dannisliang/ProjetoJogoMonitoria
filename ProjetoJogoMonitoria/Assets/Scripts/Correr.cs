using UnityEngine;
using System.Collections;

public class Correr : MonoBehaviour {

	public float velocidadeCorrendo;
	private float velocidadeAndando;
	public bool estaCorrendo;

	void Start(){
		velocidadeAndando = GetComponentInChildren<Andar> ().velocidade;
	}


	void Update(){

		if(GetComponentInChildren<ChecarColisao>().estaNoChao){
			if (Input.GetKey(KeyCode.LeftShift)) {
				estaCorrendo = true;
			}
			else{
				estaCorrendo = false;
			}
		}

		if(estaCorrendo){
			GetComponentInChildren<Andar>().velocidade = velocidadeCorrendo;
		}
		else{
			GetComponentInChildren<Andar>().velocidade = velocidadeAndando;
		}

	}


}
