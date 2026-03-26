using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdMovements : MonoBehaviour
{
    public float fuerzaSalto = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float inputVertical = Input.GetAxis("Vertical");

        if (inputVertical > 0  || Input.GetKeyDown(KeyCode.Space)) // clic o toque
        {
            rb.velocity = Vector2.up * fuerzaSalto;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Colisión con: " + collision.gameObject.name);
    }



}
