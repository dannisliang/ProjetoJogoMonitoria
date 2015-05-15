using UnityEngine;
using System.Collections;

public class Coracoes : MonoBehaviour {
	public int coracoes;
	public int coracoesMax;

	public Texture2D texturaCoracao;
	public Texture2D texturaCoracaoEscuro;

	public int larguraCoracao;
	public int alturaCoracao;
	public int espacoEntreCoracoes;
	public Vector2 posicaoInicialCoracoes;
	
	void Start (){
		coracoes = coracoesMax;
	}
	
	void OnGUI (){

		DesenharCoracoes (coracoesMax, posicaoInicialCoracoes, espacoEntreCoracoes,larguraCoracao,alturaCoracao,texturaCoracaoEscuro);
		DesenharCoracoes (coracoes, posicaoInicialCoracoes, espacoEntreCoracoes,larguraCoracao,alturaCoracao,texturaCoracao);

	}

	public void DesenharCoracoes(int numero, Vector2 posIni, int espaco, int largura, int altura, Texture2D  textura){
		float posCoracaoAnteriorX = posIni.x;
		float posCoracaoAnteriorY = posIni.y;
		float posCoracaoAtualX = posIni.x;
		float posCoracaoAtualY = posIni.y;

		for (int i = 1; i <= numero; i++) {
			if(i != 1){
				posCoracaoAtualX = posCoracaoAnteriorX + espaco + largura;
			}
			GUI.DrawTexture (new Rect (posCoracaoAtualX, posCoracaoAnteriorY, largura, altura), textura);
			posCoracaoAnteriorX = posCoracaoAtualX;
			posCoracaoAnteriorY = posCoracaoAtualY;
		}

	}
}
