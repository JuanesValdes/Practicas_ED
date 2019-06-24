using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public float vida;
    public Text vidaText;

    private void Start()
    {
        vidaText.text = vida.ToString();

    }

    private void Update()
    {
        vidaText.text = vida.ToString();
    }
}
