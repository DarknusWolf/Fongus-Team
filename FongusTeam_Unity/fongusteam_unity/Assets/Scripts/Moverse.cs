﻿using UnityEngine;
using System.Collections;

public class Moverse : MonoBehaviour {

    Rigidbody2D rg;
    public float velocidad = 20f;
	Vector3 mira_derecha = new Vector3(-8.981079f, 8.981085f, 8.981085f); //ajustar al tamaño del niño
	Vector3 mira_izquierda = new Vector3(8.981079f, 8.981085f, 8.981085f);
	public bool Voltear = true;

    void Start(){
        rg = GetComponent<Rigidbody2D>();
    }
    
    void Update(){

        if (Voltear){
			mueve_izquierda();
        }

        else{
			mueve_derecha();
        }

        Vector2 vel = GetComponent<Rigidbody2D>().velocity;
	}

    void mueve_derecha(){
        transform.localScale = mira_derecha;
		rg.velocity = new Vector2(-velocidad, 0);
    }

    void mueve_izquierda(){
        transform.localScale = mira_izquierda;
		rg.velocity = new Vector2(velocidad, 0);
    }
}
