using UnityEngine;
using System.Collections;

public class MorteInstantanea : MonoBehaviour {

	void OnTriggerStay2D(Collider2D other){
		if (other.name == "ColisaoCorpo") {
			GameObject.Find("Jogador").GetComponent<Coraçoes>().coraçoes = 0;
			GameObject.Find("Jogador").GetComponent<Controlador>().Paralizar();
		}
	}
}
