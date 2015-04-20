using UnityEngine;
using System.Collections;

public class ChecarColisaoPe : MonoBehaviour {

	public bool estaNoChao;
	public LayerMask groundLayer;

	void Update(){
		if (Physics2D.BoxCast (new Vector2(transform.position.x, transform.position.y-0.70f), new Vector2 (0.27f, 0.25f), 0, -Vector2.up, 0.10f, groundLayer)) {
			estaNoChao = true;
		} else {
			estaNoChao = false;
		}
	}
}
