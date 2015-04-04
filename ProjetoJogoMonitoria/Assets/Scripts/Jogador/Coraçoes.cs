using UnityEngine;
using System.Collections;

public class Coraçoes : MonoBehaviour {
	public int coraçoes;
	public int coraçoesMax;

	public Texture2D texturaCoraçao;
	public Texture2D texturaCoraçaoEscuro;

	public int larguraCoraçao;
	public int alturaCoraçao;
	public int espaçoEntreCoraçoes;
	public Vector2 posiçaoInicialCoraçoes;
	
	void Start (){
		coraçoes = coraçoesMax;
	}
	
	void OnGUI (){

		DesenharCoraçoes (coraçoesMax, posiçaoInicialCoraçoes, espaçoEntreCoraçoes,larguraCoraçao,alturaCoraçao,texturaCoraçaoEscuro);
		DesenharCoraçoes (coraçoes, posiçaoInicialCoraçoes, espaçoEntreCoraçoes,larguraCoraçao,alturaCoraçao,texturaCoraçao);

	}

	public void DesenharCoraçoes(int numero, Vector2 posIni, int espaço, int largura, int altura, Texture2D  textura){
		float posCoraçaoAnteriorX = posIni.x;
		float posCoraçaoAnteriorY = posIni.y;
		float posCoraçaoAtualX = posIni.x;
		float posCoraçaoAtualY = posIni.y;

		for (int i = 1; i <= numero; i++) {
			if(i != 1){
				posCoraçaoAtualX = posCoraçaoAnteriorX + espaço + largura;
			}
			GUI.DrawTexture (new Rect (posCoraçaoAtualX, posCoraçaoAnteriorY, largura, altura), textura);
			posCoraçaoAnteriorX = posCoraçaoAtualX;
			posCoraçaoAnteriorY = posCoraçaoAtualY;
		}

	}
}
