using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] private float velocityXFactor;

    // Start is called before the first frame update
    void Start()
    {
        velocityXFactor = Random.Range(-10, 10);
        GetComponent<Rigidbody2D>().velocity = new Vector2(velocityXFactor, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
