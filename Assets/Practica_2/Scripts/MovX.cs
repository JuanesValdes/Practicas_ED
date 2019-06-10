using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovX : MonoBehaviour
{
    float velocidad = 0.3f;
    int tope = 4;
    bool direccion;

    private void Start ()
    {
        direccion = true;
    }    
    
    // Update is called once per frame
    void Update()
    {
        if (direccion==true)
        {
            if (transform.position.x < tope)
            {
                transform.Translate(Vector3.right * velocidad);
            }

            if (transform.position.x >= tope)
            {
                direccion = false;
            }
        }

        if(direccion==false)
        {
            if(transform.position.y < 6)
            {
                transform.Translate(Vector3.up * velocidad);
            }
        }


        
    }
}
