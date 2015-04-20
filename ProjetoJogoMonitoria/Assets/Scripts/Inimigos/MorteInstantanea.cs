using UnityEngine;
using System.Collections;

public class MorteInstantanea : MonoBehaviour {

	void OnTriggerStay2D(Collider2D other){
		if (other.name == "ColisorCorpo") {
			other.GetComponentInParent<SofrerDano>().aplicarDano(other.transform.parent.GetComponent<Coracoes>().coracoes);
		}
	}
}
