using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tubeMoves1 : MonoBehaviour
{
    public float velocidad = 2f;

    void Update()
    {
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);

        if (transform.position.x < -15f) // fuera de pantalla
        {
            Destroy(gameObject); // se elimina
        }
    }

}
