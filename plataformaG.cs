using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformaG : MonoBehaviour {

    public int puntaje = 0;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider == "Circu")
        {
            puntaje++;
        }
            
        print("Has ganado " +puntaje +"puntos!");
    }
}
