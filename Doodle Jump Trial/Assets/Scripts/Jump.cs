using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public float forceConst = 20;
    private Rigidbody physics;

    private Rigidbody selfRigidbody;


    void OnCollisionEnter2D(Collision2D touch)
    {
        physics = touch.collider.GetComponent<Rigidbody>();

        if (physics != null)
        {
            selfRigidbody.AddForce(0, forceConst, 0, ForceMode.Impulse);
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
