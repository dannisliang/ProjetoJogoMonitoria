using UnityEngine;
using System.Collections;

public class ChecarColisaoPe : MonoBehaviour {

	public bool estaNoChao;

	void Update(){
		if (Physics2D.BoxCast (GameObject.Find ("Jogador").transform.position, new Vector2 (1, 1), 0, -Vector2.up, 0.5f)) {
			estaNoChao = true;
		} else {
			estaNoChao = false;
		}
	}
}
