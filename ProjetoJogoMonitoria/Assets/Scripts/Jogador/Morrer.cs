using UnityEngine;
using System.Collections;

public class Morrer : MonoBehaviour {
	public bool estaMorto;
	public float tempoParaRecomecar;
	public float tempoParaRecomecarMax;

	void Update () {
		if (GetComponent<Coracoes> ().coracoes <= 0) {
			tempoParaRecomecar += Time.deltaTime;
			GetComponent<Controlador>().Paralizar();
			estaMorto = true;
			if (tempoParaRecomecar >= tempoParaRecomecarMax) {
				tempoParaRecomecar = 0;
				//Application.LoadLevel (Application.loadedLevel);
				GetComponent<Renascer>().Restaurar();
			}
		}
	}
}
