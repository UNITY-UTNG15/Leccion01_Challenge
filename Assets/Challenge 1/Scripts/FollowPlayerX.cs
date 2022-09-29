/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Rodríguez Flores Raúl Alberto
* Fecha: 28/09/2022
* Funcion de Script: Este Script ayuda al poder ver al avion moviendose, ya que
* script ayuda a que la camara siga al avion.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(30,0,10);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento de la camara para seguir el avion.
        transform.position = plane.transform.position + offset;
    }
}
