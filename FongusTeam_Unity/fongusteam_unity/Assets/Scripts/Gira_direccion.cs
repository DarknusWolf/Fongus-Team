using UnityEngine;
using System.Collections;

public class Gira_direccion : MonoBehaviour {
    public Rigidbody2D rg;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter2D(Collider2D objeto){
        if (objeto.transform.tag == "Esq_izq"){
            //rg.transform.rotation = new Vector3 (rg.transform.rotation.x, rg.transform.rotation.y, rg.transform.rotation.z + 90);
        }

        if (objeto.transform.tag == "Esq_der"){

        }
    }
}
