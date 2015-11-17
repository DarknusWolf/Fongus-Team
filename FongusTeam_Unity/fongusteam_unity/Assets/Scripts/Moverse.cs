using UnityEngine;
using System.Collections;

public class Moverse : MonoBehaviour {

    Rigidbody2D rg;
    public float fuerza = 200f;
    public float velocidad_pollo = 200f;
    Vector3 mira_derecha = new Vector3(-1, 1, 1);
    Vector3 mira_izquierda = new Vector3(1, 1, 1);

    void Start(){
        rg = GetComponent<Rigidbody2D>();
    }
    
    void Update(){
        if (Input.GetKeyDown(KeyCode.Space)){
            salto();
        }

        if (Input.GetKey(KeyCode.A)){
            mueve_izquierda();
        }

        if (Input.GetKey(KeyCode.D)){
            mueve_derecha();
        }

        Vector2 vel = GetComponent<Rigidbody2D>().velocity;
        Debug.DrawLine(transform.position, new Vector3(transform.position.x + vel.x, transform.position.y + vel.y, transform.position.z));
    }

    void salto(){
        rg.AddForce(new Vector2(0, fuerza));
    }

    void mueve_derecha(){
        transform.localScale = mira_derecha;
        rg.AddForce(new Vector2(velocidad_pollo, 0));
    }

    void mueve_izquierda(){
        transform.localScale = mira_izquierda;
        rg.AddForce(new Vector2(-velocidad_pollo, 0));

    }
}
