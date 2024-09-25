using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reiniciarposicion : MonoBehaviour
{
    private Vector3 startPosition; // Almacena la posición inicial

    
    void Start()
    {
        startPosition = transform.position;// Guarda la posición inicial del GameObject

    }

    
   
    
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("balaenemiga"))// si jugador choca con enemigo
            {
                ResetToStartPosition();


            }
        }
         



    void ResetToStartPosition()
    {

        transform.position = startPosition;// Reinicia la posición del GameObject a la posición inicial
    }
}
