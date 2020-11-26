using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private Text ScoreText;
    [SerializeField]
    private Text text;


    [SerializeField]
    private int curScore;



    public void GetItem()
    {
        

       

        --curScore;

        ScoreText.text = curScore.ToString();
        if (curScore <= 0)
        {
            text.text = "클리어 했어요!!!!";
            ScoreText.text = "";

            return;
        }

    }


   
}
