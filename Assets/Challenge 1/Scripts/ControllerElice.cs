/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Rodríguez Flores Raúl Alberto
* Fecha: 28/09/2022
* Funcion de Script: Este Script ayuda a que la elice del avion gire.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerElice : MonoBehaviour
{   
    public float velocidadGiro = 1200.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento de la elice del avion.
        transform.Rotate(Vector3.forward * velocidadGiro);
    }
}
