using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tubeMoves : MonoBehaviour
{
    public float velocidad = 2f;

    void Update()
    {
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);

        if (transform.position.x < -15f) // fuera de pantalla
        {
            Destroy(gameObject); // se elimina
        }
    }

}
