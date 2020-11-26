using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    private Score score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * 30f);



        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Ball")
        {


            Destroy(gameObject);
            

        }

    }

}
