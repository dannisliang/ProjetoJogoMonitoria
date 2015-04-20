using UnityEngine;
using System.Collections;

public class Pular_Old : MonoBehaviour {
	public bool apertouPular;
	public bool iniciouPulo;
	public float tempoCarga;
	public float forca;
	public float forcaMin;
	public float forcaMax;
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
			if (forca < forcaMax) {
				forca += tempoCarga;
				if(forca < forcaMin){
					forca = forcaMin;
				}
			} else {
				forca = forcaMax;
			}
		}

		if ((Input.GetKeyUp (KeyCode.Space) && apertouPular) || forca == forcaMax) {
			apertouPular = false;
			iniciouPulo = true;
		}

	}

	void FixedUpdate(){
		if (iniciouPulo) {
			if(GetComponentInChildren<ChecarColisaoPe>().estaNoChao){
				GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D> ().velocity.x,forca);
			}
			else{
				if(pulosNoAr < pulosNoArMax){
					GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D> ().velocity.x,forcaMax);
					pulosNoAr++;
				}
			}

			forca = forcaMin;
			iniciouPulo = false;
			tempoCarga = 0;
		}
		

	}
	
}
