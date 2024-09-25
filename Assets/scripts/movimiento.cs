using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movimiento : MonoBehaviour
{
    public float speed = 5;

    public Rigidbody rb;

    public bool tienepowerup;






    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(speed * inputX, speed * inputY);
        rb.velocity = movement;


    }
    


    

    
    




}

