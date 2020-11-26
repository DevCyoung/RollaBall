using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextManager : MonoBehaviour
{

    [SerializeField]
    private Text Score;
    [SerializeField]
    private Text text;


   


    public void SetScore(int count)
    {
        Score.text = count.ToString();


    }

}
