using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum TorretaIA
{
    Buscando,
    Ataque
}

public class TorretaD : MonoBehaviour
{
    public Rigidbody bullet;
    public Transform[] cañon;
    public float fuerzaDisparo;
    public TorretaIA estadoActual = new TorretaIA();
    int ContadorMisiles;

    void Start ()
    {
        ContadorMisiles = 0;
        estadoActual = TorretaIA.Buscando;
    }



    // Update is called once per frame
    void Update()
    {
        if (estadoActual==TorretaIA.Ataque)
        {
            for (int i =0; i < 3; i++)
            {
                Rigidbody bulletPos = Instantiate(bullet, cañon[i].position, cañon[i].rotation) as Rigidbody;
                bulletPos.AddForce(cañon[i].forward * fuerzaDisparo);
                ContadorMisiles = i+1;

                if (ContadorMisiles >= 3 && i >= cañon.Length-1)
                {
                    ContadorMisiles = 3;
                    estadoActual = TorretaIA.Buscando;
                }
            }
          
        }

    }
}

