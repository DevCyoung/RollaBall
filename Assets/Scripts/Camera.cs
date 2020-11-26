using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    private Transform targetTransform;

    private Transform myTransform;

    [SerializeField]
    private Vector3 pivot;



   
    void Start()
    {
        myTransform = transform;



    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = targetTransform.position;

        Vector3 myPosition = myTransform.position;

        Vector3 goPosition = new Vector3( target.x + pivot.x , target.y + 6.8f + pivot.y, target.z - 4.5f + +pivot.z);
       
        myTransform.position = Vector3.Lerp(myPosition, goPosition, Time.deltaTime);



    }
}
