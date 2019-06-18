using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPuntos : MonoBehaviour
{
    public float velocidad;
    public Transform sierra;
    public Transform[] puntos;
    public Transform target;
    public int indiceTarget;
    // Start is called before the first frame update
    void Start()
    {
        target = puntos[1];
        sierra.position = target.position;
        velocidad = velocidad * Time.deltaTime;
        indiceTarget = 0;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - sierra.position;
        float distance = Vector3.Distance(sierra.position, target.position);

        sierra.Translate(dir.normalized * velocidad, Space.World);

        if ( distance <= 0.5f)
        {
            if (indiceTarget >= puntos.Length - 1)
            {
                indiceTarget = 0;
                target = puntos[indiceTarget];
            }

            indiceTarget++;
            target = puntos[indiceTarget];


        }
    }
}
