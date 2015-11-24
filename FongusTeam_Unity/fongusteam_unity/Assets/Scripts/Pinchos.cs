using UnityEngine;
using System.Collections;

public class Pinchos : MonoBehaviour {
    public GameObject jugador;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D objeto){
        if (objeto.transform.tag == "Player"){
            Debug.Log("Moriste!");
            Destroy(jugador);
        }
    }
}
