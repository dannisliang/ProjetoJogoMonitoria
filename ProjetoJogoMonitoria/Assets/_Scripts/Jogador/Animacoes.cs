using UnityEngine;
using System.Collections;

public class Animacoes : MonoBehaviour {
	public float h;
	public float velocidade;
	public bool direita;
	public bool esquerda;
	public bool pulando;


	void Start () {
		esquerda = true;
	}

	void Update () {		

		h = GetComponent<Andar> ().h;
		velocidade = GetComponent<Andar> ().velocidade;
		GetComponent<Animator> ().SetBool ("Ferido", GetComponent<SofrerDano> ().estaInvulneravel);
		GetComponent<Animator> ().SetBool ("EstaNoChao", GetComponent<ChecarColisao> ().estaNoChao);
		GetComponent<Animator> ().SetBool ("Pulando", GetComponent<Pular> ().estaPulando);
		GetComponent<Animator> ().SetBool ("Caindo", GetComponent<Pular> ().caindo);
		GetComponent<Animator> ().SetBool ("PulandoNoAr", GetComponent<Pular> ().estaPulandoNoAr);
		GetComponent<Animator> ().SetFloat ("VelocidadeY", GetComponent<Rigidbody2D> ().velocity.y);
		GameObject.Find ("Wings").transform.GetComponent<Animator>().SetBool("BaterAsa", GetComponent<Pular> ().estaPulandoNoAr);

		if (h * velocidade != 0) {
			GetComponent<Animator> ().SetBool ("Andando", true);


		} else {
			GetComponent<Animator> ().SetBool ("Andando", false);
		}
		if(h > 0 && esquerda){
			transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
			direita = true;
			esquerda = false;
		}
		
		if(h < 0 && direita){
			transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
			direita = false;
			esquerda = true;
		}

		if (GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("Walk")) {
			GetComponent<Animator> ().speed = (velocidade / 2) * Mathf.Abs (Input.GetAxis ("Horizontal"));
		} else {
			GetComponent<Animator> ().speed = 1;
		}

	}
}