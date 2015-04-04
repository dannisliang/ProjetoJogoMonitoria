using UnityEngine;
using System.Collections;

public class CausarDanoAoEncostar : MonoBehaviour {
	public int Dano;

	void OnTriggerStay2D(Collider2D other){
		if (other.name == "ColisaoCorpo") {
			if(other.GetComponentInParent<SofrerDano>().estaInvulneravel == false){
				other.GetComponentInParent<SofrerDano>().aplicarDano(Dano, transform.position.x);
			}
		}
	}

}
