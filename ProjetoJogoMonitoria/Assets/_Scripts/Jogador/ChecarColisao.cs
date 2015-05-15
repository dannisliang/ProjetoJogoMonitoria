using UnityEngine;
using System.Collections;

public class ChecarColisao : MonoBehaviour {

	public bool estaNoChao;
	public LayerMask groundLayer;
	public Transform debugSprite;
	public Vector2 tamanho;
	public Vector2 posicao;


	void Update(){
		posicao = new Vector2(transform.position.x, transform.position.y-0.70f);
		tamanho = new Vector2 (0.27f, 0.25f);
		                     
		debugSprite.transform.position = new Vector2(posicao.x, posicao.y-0.10f);
		debugSprite.transform.localScale = tamanho;
		                            
		if (Physics2D.BoxCast (posicao, tamanho, 0, -Vector2.up, 0.10f, groundLayer)) {
			estaNoChao = true;
			debugSprite.GetComponent<SpriteRenderer>().color = Color.red;
		} else {
			estaNoChao = false;
			debugSprite.GetComponent<SpriteRenderer>().color = Color.green;
		}
	}
}
