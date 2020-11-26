using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum COLORVALUE
{

    RED,
    YELLOW,
    BLUE,
    GREEN,
   

}


public class Box : MonoBehaviour
{
    [SerializeField]
    COLORVALUE boxColor;

    [SerializeField]
    private SystemManager sm;


    [SerializeField]
    private MeshRenderer mesh;

    [SerializeField]
    private Material[] mats;

    [SerializeField]
    private bool isBox;

    public COLORVALUE BoxColor { get => boxColor; }

    


    

    [SerializeField]
    private float power;

    private void Start()
    {
        SetColor();



        //mat = GetComponent<MeshRenderer>().materials;

        //mat[0].SetColor(null, ConvertValueToColor(boxColor));


        //SetColor();

    }






    public void SetColor()
    {
        ConvertValueToColor();


    }

    private void OnCollisionEnter(Collision collision)
    {
        

        if (collision.transform.tag == "Ball")
        {
            Rigidbody rgd = collision.transform.GetComponent<Rigidbody>();
            rgd.velocity = Vector3.zero;

            rgd.AddForce(Vector3.up * power , ForceMode.Impulse);

        }

        if (!isBox)
            return;

        if( sm.isFinish)
        {
            return;
        }


        boxColor++;
        if ((int)boxColor == 4)
        {
            boxColor = 0;

        }
        ConvertValueToColor();



    }


    public void ConvertValueToColor( )
    {
        for (int i = 0; i < 4; i++)
        {
            if( i == (int)boxColor)
            {
                mesh.material = mats[i];

            }

        }

       
    }




}
