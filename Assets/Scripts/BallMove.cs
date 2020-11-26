using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BallMove : MonoBehaviour
{
    float x;
    float y;

    [SerializeField]
    private Rigidbody rgd;
    [SerializeField]
    private float speed;

    [SerializeField]
    private bool isBox;

    [SerializeField]
    private Text text1;
    [SerializeField]
    private Text text2;

  

    int curCoint = 0;





    [SerializeField]
    private bool isGround;

    public int itemCount = 0;



    void Start()
    {
        rgd = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
     

        //if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        //{
        //    rgd.AddForce(Vector3.up * 300f, ForceMode.Force);
        //    isGround = false;

        //}



    }

    private void FixedUpdate()
    {
        Move();

    }


    private void Move()
    {
        x = Input.GetAxisRaw("Horizontal");

        y = Input.GetAxisRaw("Vertical");

        

        rgd.AddForce( new Vector3(y, 0, -x) * speed, ForceMode.Acceleration );

        //Debug.Log(y);



      
    }

    private void OnCollisionEnter(Collision collision)
    {
        if( collision.transform.tag == "Tile")
        {

            isGround = true;

        }





    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Tile")
        {

            isGround = true;

        }


        if (other.transform.tag == "Item")
        {
            curCoint++;

            text2.text = curCoint.ToString();







        }



    }






}
