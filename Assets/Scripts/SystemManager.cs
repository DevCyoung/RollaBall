using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemManager : MonoBehaviour
{
    [SerializeField]
    private Box[] boxes;

    [SerializeField]
    private GameObject winText;

    [SerializeField]
    private COLORVALUE winValue;

    int count;

    private bool isWin;

    public bool isFinish;




    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            Debug.Log("누름");


            Application.Quit();


        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < boxes.Length; i++)
        {
            if (boxes[i].BoxColor == winValue)
            {
                count++;

            }
            else
            {
                count = 0;
                return;
            }

            if( count >= 6 && isWin == false)
            {
                isWin = true;
                isFinish = true;

                WinText();
                SoundSystem.Play(SoundSystem.inst.clear);
                Debug.Log("you win!");

            }


        }


        



    }

    public void WinText()
    {
        winText.SetActive(true);

    }




}
