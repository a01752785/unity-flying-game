using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// David Damian Galan A01752785

public class MovimientoGoomba : MonoBehaviour
{
    public static float velocidadX = -2;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        // Mantiene velocidad constante
        rb.velocity = new Vector2(1 * velocidadX, rb.velocity.y);
    }
}
