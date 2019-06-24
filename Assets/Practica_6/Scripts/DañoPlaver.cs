using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoPlaver : MonoBehaviour
{
    Vida vidajugador;

    void Start()
    {
        vidajugador = GameObject.Find("Player").GetComponent<Vida>();
    }
    private void OnCollisionEnter(Collision collision)
    {
    

        if (collision.gameObject.tag == "Player")
        {
            vidajugador.vida -= 3;
        }

    }

}
