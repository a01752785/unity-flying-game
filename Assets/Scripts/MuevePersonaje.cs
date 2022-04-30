using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// David Damian Galan A01752785

public class MuevePersonaje : MonoBehaviour
{
    public float velocidadX = 10;    // Horizontal (para movimiento horizontal) 
    public float velocidadY = 10;    // Vertical (para el salto) 
    // El componente Rigidbody del personaje (para física) 
    private Rigidbody2D rb;

    // Animator
    private Animator animator;

    // Sprite Rendered
    private SpriteRenderer sprRenderer;

    // Esta en piso
    public bool estaEnPiso = true;

    // Start is called before the first frame update 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprRenderer = GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movHorizontal * velocidadX, rb.velocity.y);
        float movVertical = Input.GetAxis("Vertical");
        if (movVertical > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, movVertical * velocidadY);
        }
        // Velocidad (animator)
        animator.SetFloat("velocidad", Mathf.Abs(rb.velocity.x));

        // Direccion correcta
        if (rb.velocity.x < 0)
        {
            sprRenderer.flipX = true;
        }
        else
        {
            sprRenderer.flipX = false;
        }

        // Animacion de salto
        animator.SetBool("enPiso", estaEnPiso);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        estaEnPiso = true;
        print(estaEnPiso);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        estaEnPiso = false;
        print(estaEnPiso);
    }

}
