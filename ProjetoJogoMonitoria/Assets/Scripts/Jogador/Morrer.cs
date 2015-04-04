using UnityEngine;
using System.Collections;

public class Morrer : MonoBehaviour {
	public bool estaMorto;
	public float tempoParaRecomeçar;
	public float tempoParaRecomeçarMax;

	void Update () {
		if (GetComponent<Coraçoes> ().coraçoes <= 0) {
			tempoParaRecomeçar += Time.deltaTime;
			estaMorto = true;
			if (tempoParaRecomeçar >= tempoParaRecomeçarMax) {
				tempoParaRecomeçar = 0;
				Application.LoadLevel (Application.loadedLevel);
			}
		}
	}
}
