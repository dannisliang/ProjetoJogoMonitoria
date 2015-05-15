using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {
	public Vector2 posicao;

	void OnTriggerEnter2D(Collider2D outro){
		if (outro.name == "ColisorCorpo") {
			posicao = transform.position;
			Desativar();
			Ativar ();
			outro.transform.parent.GetComponent<Renascer>().posicao = posicao;
		}
	
	}

	public void Ativar(){
		transform.FindChild("FogoAzul").GetComponent<SpriteRenderer>().enabled = true;
	}

	public void Desativar(){
		foreach (var este in FindObjectsOfType(typeof(GameObject)) as GameObject[]){
			if(este.GetComponent<Checkpoint>()){
				este.transform.FindChild("FogoAzul").GetComponent<SpriteRenderer>().enabled = false;
			}
		}
	}
}
