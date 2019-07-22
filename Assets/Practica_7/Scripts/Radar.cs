using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : MonoBehaviour
{
    TorretaD torretaRadar;


    // Start is called before the first frame update
    void Start()
    {
        torretaRadar = GetComponentInParent<TorretaD>();
      
    }

   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            torretaRadar.estadoActual = TorretaIA.Ataque;

            Debug.Log("Te voa shingar");
        }
    }
}
