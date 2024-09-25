using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectil_destruir : MonoBehaviour
{
    public GameObject balajugador;
    
    private void OnTriggerEnter(Collider other)
    {
       
        
            Destroy(gameObject);//redordatorio...game(minuscula) Object(mayuscula)



        
    }

}
