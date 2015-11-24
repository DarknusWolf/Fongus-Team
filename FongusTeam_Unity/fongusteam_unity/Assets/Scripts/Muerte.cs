using UnityEngine;
using System.Collections;

public class Muerte : MonoBehaviour {
<<<<<<< HEAD
=======
    public GameObject jugador;
>>>>>>> 4198a94449910f298af99fd49c27ceb233f1a719

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D objeto) {
        if (objeto.transform.tag == "Player") {
            Debug.Log("Moriste tu");
<<<<<<< HEAD
=======
            Destroy(jugador);
>>>>>>> 4198a94449910f298af99fd49c27ceb233f1a719
        }
    }
}
