using UnityEngine;
using System.Collections;

public class Pular : MonoBehaviour {
	public bool apertouPular;
	public bool iniciouPulo;
	public float tempoCarga;
	public float força;
	public float forçaMin;
	public float forçaMax;
	public float multiplicador;
	public int pulosNoAr;
	public int pulosNoArMax;



	void Update () {

		if (GetComponentInChildren<ChecarColisaoPe>().estaNoChao) {
			pulosNoAr = 0;
		}


		if(Input.GetKeyDown(KeyCode.Space)){
			apertouPular = true;
		}

		if (apertouPular) {
			tempoCarga += Time.deltaTime*multiplicador;
			if (força < forçaMax) {
				força += tempoCarga;
				if(força < forçaMin){
					força = forçaMin;
				}
			} else {
				força = forçaMax;
			}
		}

		if ((Input.GetKeyUp (KeyCode.Space) && apertouPular) || força == forçaMax) {
			apertouPular = false;
			iniciouPulo = true;
		}

	}

	void FixedUpdate(){
		if (iniciouPulo) {
			if(GetComponentInChildren<ChecarColisaoPe>().estaNoChao){
				GetComponent<Rigidbody2D>().velocity = new Vector2(0,força);
			}
			else{
				if(pulosNoAr < pulosNoArMax){
					GetComponent<Rigidbody2D>().velocity = new Vector2(0,forçaMax);
					pulosNoAr++;
				}
			}
			força = forçaMin;
			iniciouPulo = false;
			tempoCarga = 0;
		}
		

	}
	
}
