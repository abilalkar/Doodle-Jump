using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public float jumpPower;
    private Vector2 characterSpeed;
    private Rigidbody2D physics;


    void OnCollisionEnter2D(Collision2D touch)
    {
        physics = touch.collider.GetComponent<Rigidbody2D>();

        if (physics != null)
        {
            characterSpeed = physics.velocity;
            characterSpeed.y = jumpPower;
            physics.velocity = characterSpeed;
        }
    }






    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
