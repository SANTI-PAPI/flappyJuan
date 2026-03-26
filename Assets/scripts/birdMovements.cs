using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class birdMovements : MonoBehaviour
{
    public float fuerzaSalto = 3f;
    private Rigidbody2D rb;
    public GameObject Panel;

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
        Panel.SetActive(true);
        Time.timeScale = 0f;
        Debug.Log("Colisión con: " + collision.gameObject.name);
    }



}
