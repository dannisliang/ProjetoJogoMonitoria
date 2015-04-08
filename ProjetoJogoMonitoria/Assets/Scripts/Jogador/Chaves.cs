using UnityEngine;
using System.Collections;

public class Chaves : MonoBehaviour {

	public int chaves;
	public float largura;
	public float altura;
	public Texture2D textura;
	public Vector2 posiçao;

	void Start(){
		posiçao.x = Screen.width - largura*2;
		posiçao.y = 0;
	}

	void OnGUI(){
		GUI.DrawTexture (new Rect (posiçao.x, posiçao.y, largura, altura), textura);
		GUI.Label (new Rect (posiçao.x + largura + 10, posiçao.y, largura, altura), chaves.ToString());
	}


}
