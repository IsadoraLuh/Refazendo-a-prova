using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour

{
    float speed = 3.5f;
    Rigidbody2D rigidbody2D;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -GameManager.instance.ScreenBounds.x) // o - é pq é da esqueda 
        {
            Destroy(gameObject);
        }
        else
        {
            rigidbody2D.velocity = Vector2.left * speed;
        }
    }


}
