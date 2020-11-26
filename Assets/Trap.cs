using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    

   
    float Angle;

    [SerializeField]
    float scale;

    void Start()
    {




    }

    // Update is called once per frame
    void Update()
    {

        
        float move = Mathf.Sin( Mathf.Deg2Rad * Angle) ;
        transform.position += new Vector3(0, 0, move * scale);
        Angle += 0.5f;





    }
}
