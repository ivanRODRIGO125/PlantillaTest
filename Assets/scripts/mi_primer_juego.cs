using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mi_primer_juego : MonoBehaviour
{
    public string nombre_personaje = "arthur";
    private string videojuego_favorito = "rdr2";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("el personaje principal de"+" "+ videojuego_favorito+" "+ "es"+" " + nombre_personaje );


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
