using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] private float velocityXFactor = -5;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(velocityXFactor, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
