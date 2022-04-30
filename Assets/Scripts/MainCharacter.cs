using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    [SerializeField] private float velocityXFactor = 10;
    [SerializeField] private float velocityYFactor = 10;    
    

    // Start is called before the first frame update 
    void Start()
    {
        
    }
    private void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        if (horizontalMovement != 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(horizontalMovement * velocityXFactor,
                GetComponent<Rigidbody2D>().velocity.y);
        }
        
        float verticalMovement = Input.GetAxis("Vertical");
        if (verticalMovement != 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 
                verticalMovement * velocityYFactor);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GetComponent<HealthSystem>().SubtractPoints();
        }
        else
        {
            GetComponent<HealthSystem>().AddPoints();
        }
        int points = GetComponent<HealthSystem>().GetPoints();
        HUDHandler.instance.UpdatePoints(points);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
