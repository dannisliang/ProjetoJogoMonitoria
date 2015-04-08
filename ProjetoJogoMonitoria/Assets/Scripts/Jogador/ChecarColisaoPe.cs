using UnityEngine;
using System.Collections;

public class ChecarColisaoPe : MonoBehaviour {

	public bool estaNoChao;
	public LayerMask groundLayer;

	void Update(){
		if (Physics2D.BoxCast (new Vector2(transform.parent.position.x, transform.parent.position.y-0.65f), new Vector2 (0.65f, 0.25f), 0, -Vector2.up, 0.25f, groundLayer)) {
			estaNoChao = true;
		} else {
			estaNoChao = false;
		}
	}
}
