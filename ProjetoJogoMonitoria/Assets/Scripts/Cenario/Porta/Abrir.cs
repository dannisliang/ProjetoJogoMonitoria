using UnityEngine;
using System.Collections;

public class Abrir : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D outro){
		if (outro.name == "ColisorCorpo") {
			if(outro.GetComponentInParent<Chaves>().chaves > 0){
				outro.GetComponentInParent<Chaves>().chaves--;
				Transform p;
				p = transform.parent;
				p.FindChild("PortaFechada").GetComponent<SpriteRenderer>().enabled = false;
				p.FindChild("PortaFechada").GetComponent<BoxCollider2D>().enabled = false;
				p.FindChild("PortaAberta").GetComponent<SpriteRenderer>().enabled = true;
				Destroy(this.gameObject);
			}

		}
	}
}
