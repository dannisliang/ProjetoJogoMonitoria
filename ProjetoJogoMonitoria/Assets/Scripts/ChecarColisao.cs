using UnityEngine;
using System.Collections;

public class ChecarColisao : MonoBehaviour {

	public bool estaNoChao;

	void OnTriggerStay2D(){
		print ("Ta no chao");
		estaNoChao = true;
	}
	
	void OnTriggerExit2D(){
		print ("no ar");
		estaNoChao = false;
		
	}
}
