using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sierra_SinX : MonoBehaviour
{
    private Vector3 originalTransform;

    public float velocidad;
    public float distancia;


    // Start is called before the first frame update
    void Start()
    {
        originalTransform = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = originalTransform + new Vector3(Mathf.Sin(Time.time * velocidad) * distancia,0 ,0);
    }
}
