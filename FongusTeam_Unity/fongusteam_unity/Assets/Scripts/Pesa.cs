using UnityEngine;
using System.Collections;

public class Pesa : MonoBehaviour {
    Rigidbody2D rg;
	public string nombre = "Player";

	// Use this for initialization
	void Start () {
        rg = GetComponent<Rigidbody2D>();
        rg.gravityScale = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D objeto){
		string etiqueta = objeto.transform.tag;
		Debug.Log (etiqueta);
		if (etiqueta == nombre) {
			rg.gravityScale = 1;
		}
	}
}
