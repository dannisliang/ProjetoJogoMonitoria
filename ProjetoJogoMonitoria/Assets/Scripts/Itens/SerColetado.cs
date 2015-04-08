using UnityEngine;
using System.Collections;

public class SerColetado : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D outro){
		if (outro.name == "ColisorCorpo") {
			if(outro.GetComponentInParent<Morrer>().estaMorto == false){
				outro.GetComponentInParent<ColetarItem>().AplicarEfeito(this.gameObject.GetComponent<SpriteRenderer>().sprite.name);
				Destroy(this.gameObject);
			}
		}
	}
}
