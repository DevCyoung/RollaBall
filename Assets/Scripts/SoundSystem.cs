using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour
{
    public static SoundSystem inst;


    public AudioSource bounce;
    public AudioSource eatItem;
    public AudioSource clear;


    //public AudioSource spit;
    //public AudioSource changeColor;
    //public AudioSource breakable;
    //public AudioSource interaction;
    //public AudioSource getHeart;



    public static void Play(AudioSource source)
    {
        source.Play();
    }
    

    private void Awake()
    {
        inst = this;
    }
}
