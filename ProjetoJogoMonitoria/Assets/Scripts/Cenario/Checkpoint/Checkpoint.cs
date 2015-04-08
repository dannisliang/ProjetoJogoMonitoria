using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {
	public Vector2 posiçao;

	void OnTriggerEnter2D(Collider2D outro){
		if (outro.name == "ColisorCorpo") {
			posiçao = outro.transform.parent.position;
			Desativar();
			Ativar ();
			outro.transform.parent.GetComponent<Renascer>().posiçao = posiçao;
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
