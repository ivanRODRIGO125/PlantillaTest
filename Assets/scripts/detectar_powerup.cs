using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powrup : MonoBehaviour
{
    public bool tienepowerup;
    public float velocidad_agregada;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("POWERUP"))//si pj coliciona con otro objeto(busca el tag de ese otro objeto para identificar)

        {
            Player.GetComponent<movimiento>().speed += velocidad_agregada;
            tienepowerup = true;
            Destroy(other.gameObject);
        }

    }


}
