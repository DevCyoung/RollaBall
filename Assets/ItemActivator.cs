using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class ItemActivator : MonoBehaviour
{
    [SerializeField]
    private GameObject item;

    [SerializeField]
    private int size;
    [SerializeField]
    private int scale;

    int Angle;
    int AngleSize;



    void Start()
    {
        AngleSize = 360 / size;
        for (int i = 0; i < size; i++)
        {
            GameObject obj = Instantiate(item);

            obj.transform.position = new Vector3(Mathf.Cos(Mathf.Deg2Rad * Angle) * scale, 1f, Mathf.Sin(Mathf.Deg2Rad * Angle) * scale) ;

            Angle += AngleSize;






        }

    }

    // Update is called once per frame
    void Update()
    {
        



       



    }
}
