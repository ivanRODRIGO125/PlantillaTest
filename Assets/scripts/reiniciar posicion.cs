using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reiniciarposicion : MonoBehaviour
{
    private Vector3 startPosition; // Almacena la posici�n inicial

    
    void Start()
    {
        startPosition = transform.position;// Guarda la posici�n inicial del GameObject

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

        transform.position = startPosition;// Reinicia la posici�n del GameObject a la posici�n inicial
    }
}
