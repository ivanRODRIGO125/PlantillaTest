using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Projectile : Projectile
{
    public float projectileSpeed;
    public GameObject balaenemiga;
    public GameObject balajugador;
    public Rigidbody rb;

    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    
    public override void Update()
    {
        ProjectileDirection();
        base.Update();
    }

    public virtual void ProjectileDirection()
    {
        rb.velocity = new Vector3(1 * projectileSpeed, rb.velocity.y, 0);
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("balaenemiga"))
        {
            Destroy(other.gameObject);//el other se usa para el game object que no esta vinculado a este script
            Destroy(gameObject);//redordatorio...game(minuscula) Object(mayuscula)


        }
         

    
}
}
