using UnityEngine;
using System.Collections;

public class CausarDanoAoEncostar : MonoBehaviour {
	public int Dano;

	void OnTriggerStay2D(Collider2D other){
		if (other.name == "ColisorCorpo") {
			if(other.GetComponentInParent<SofrerDano>().estaInvulneravel == false){
				other.GetComponentInParent<SofrerDano>().aplicarDano(Dano, 3, transform.position.x);
			}
		}
	}

}
