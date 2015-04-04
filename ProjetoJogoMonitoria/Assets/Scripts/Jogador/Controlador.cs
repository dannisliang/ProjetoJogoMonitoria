using UnityEngine;
using System.Collections;

public class Controlador : MonoBehaviour {
	public bool podeAndar;
	public bool podeCorrer;
	public bool podePular;
	
	void Update () {
		GetComponent<Andar> ().enabled = podeAndar;
		GetComponent<Correr> ().enabled = podeCorrer;
		GetComponent<Pular> ().enabled = podePular;
	}

	public void Paralizar(){
		podeAndar = false;
		podeCorrer = false;
		podePular = false;
	}

	public void Desparalizar(){
		if (GetComponent<Morrer> ().estaMorto == false) {
			podeAndar = true;
			podeCorrer = true;
			podePular = true;
		}
	}
}
