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
    int contadorMisiles;
    public int aumento = 0;

    private void Start()
    {
        contadorMisiles = 0;
        estadoActual = TorretaIA.Buscando;

        //StartCoroutine(MisilesAtaque());
    }

    // Update is called once per frame
    //void Update()
    //{
    //if (estadoActual == TorretaIA.Ataque)


    //{
    //for (int i =0; i<3; i++)
    //{
    //Rigidbody bulletPos = Instantiate(bullet, cañon[i].position, cañon[i].rotation) as Rigidbody;

    //bulletPos.AddForce(cañon[i].forward * fuerzaDisparo);
    //contadorMisiles = i+1;
    //if (contadorMisiles >= 3&&i>=cañon.Length-1)
    //{
    //contadorMisiles = 3;
    //estadoActual = TorretaIA.Buscando;
    //}
    //}

    //}

    //}
    //fin update
    public IEnumerator MisilesAtaque()
    {
        if (estadoActual == TorretaIA.Ataque)
        {
            Rigidbody bulletpos = Instantiate(bullet, cañon[aumento].position, cañon[aumento].rotation) as Rigidbody;
            bulletpos.AddForce(cañon[aumento].forward * fuerzaDisparo);
            contadorMisiles++;
            yield return new WaitForSeconds(1);
            aumento++;
            if (aumento == 8 && aumento > cañon.Length - 1)
            {
                aumento = 0;
            }
            if (contadorMisiles != 9)
            {
                StartCoroutine(MisilesAtaque());
            }
            else if (contadorMisiles == 9)
            {
                estadoActual = TorretaIA.Buscando;
            }
            yield return null;

        }
    }
}

