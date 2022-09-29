/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Rodríguez Flores Raúl Alberto
* Fecha: 28/09/2022
* Funcion de Script: Este Script ayuda al player a poder mover al objeto de
* tipo avion con el cual podra realizarce con exito este juego.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // obtener la entrada vertical del usuario
        verticalInput = Input.GetAxis("Vertical");

        // mover el avión hacia adelante a una velocidad constante
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // inclina el avión hacia arriba/abajo según las teclas de flecha arriba/abajo
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
