using UnityEngine;
using System.Collections;

public class ColetarItem : MonoBehaviour {

	void Start(){
	
	}

	public void AplicarEfeito(string tipoItem){
		switch(tipoItem){
			case "Chave":
				GetComponent<Chaves>().chaves++;
			break;
			case "Pena":
				GetComponent<Pular>().pulosNoArMax++;
			break;
		}
	}
}
