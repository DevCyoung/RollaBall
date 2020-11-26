using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            GameObject ball = collision.gameObject;
            ball.transform.position = new Vector3(0, 3, 0);
            Rigidbody rgd = ball.GetComponent<Rigidbody>();
            rgd.velocity = Vector3.zero;

        }
    }

}
