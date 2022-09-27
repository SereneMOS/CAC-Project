using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTransition : MonoBehaviour
{
    int SlideNumber;
    public int Level2;
    public int Level3;
    public int Level4;
    public int Level5;
    public Animator transition;
    public Animator transition2;
    public Animator transition3;
    public Animator transition4;

    void Update()
    {
        /*
        if (SlideNumber == Level2 || SlideNumber == Level3 || SlideNumber == Level4)
        {
            transition.SetTrigger("Pass");
            transition.SetTrigger("Start");
        }    */ 
    }

    public void AddSlide()
    {
        SlideNumber += 1;
        if (SlideNumber == Level2) //|| SlideNumber == Level3 || SlideNumber == Level4
        {
            transition.SetTrigger("Pass");
            transition.SetTrigger("Start");
        }
        if (SlideNumber == Level3)
        {
            transition2.SetTrigger("Pass");
            transition2.SetTrigger("Start");
        }
        if (SlideNumber == Level4)
        {
            transition3.SetTrigger("Pass");
            transition3.SetTrigger("Start");
        }
        if (SlideNumber == Level5)
        {
            transition4.SetTrigger("Pass");
            transition4.SetTrigger("Start");
        }
    }
}
