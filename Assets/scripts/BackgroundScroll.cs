using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float velocidad = 2f;
    public float ancho = 0.4683131f; // ancho del sprite

    void Update()
    {
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);

        if (transform.position.x < -ancho)
        {
            transform.position = new Vector2(transform.position.x + 2 * ancho, transform.position.y);
        }
    }

}
