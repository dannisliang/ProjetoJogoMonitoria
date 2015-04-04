using UnityEngine;
using System.Collections;

public class Correr : MonoBehaviour {

	public float velocidadeCorrendo;
	private float velocidadeAndando;
	public bool estaCorrendo;

	void Start(){
		velocidadeAndando = GetComponent<Andar> ().velocidade;
	}

	void Update(){

		if(GetComponentInChildren<ChecarColisaoPe>().estaNoChao){
			if (Input.GetKey(KeyCode.LeftShift)) {
				estaCorrendo = true;
			}
			else{
				estaCorrendo = false;
			}
		}

		if(estaCorrendo){
			GetComponent<Andar>().velocidade = velocidadeCorrendo;
		}
		else{
			GetComponent<Andar>().velocidade = velocidadeAndando;
		}

	}


}
