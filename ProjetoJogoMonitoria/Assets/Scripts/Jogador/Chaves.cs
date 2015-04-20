using UnityEngine;
using System.Collections;

public class Chaves : MonoBehaviour {

	public int chaves;
	public float largura;
	public float altura;
	public Texture2D textura;
	public Vector2 posicao;

	void Start(){
		posicao.x = Screen.width - largura*2;
		posicao.y = 0;
	}

	void OnGUI(){
		GUI.DrawTexture (new Rect (posicao.x, posicao.y, largura, altura), textura);
		GUI.Label (new Rect (posicao.x + largura + 10, posicao.y, largura, altura), chaves.ToString());
	}


}
