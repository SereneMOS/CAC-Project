using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2Start : MonoBehaviour
{
    public int Startx;
    public int Starty;
    public int VisibleSlide;
    int SlideNumber = 0;
    bool Active = false;
    bool Clicked = false;
    public int WhichPuzzle;
    bool Done = false;

    void Start()
    {
        transform.position = new Vector3(-500, -500, 0);
    }

    void Update()
    {
        
            GameObject IsActive = GameObject.Find("Button_Correct");
            PointAndClick Answered = IsActive.GetComponent<PointAndClick>();
            bool Done = Answered.Correct;
            Clicked = Done;
            if (SlideNumber != VisibleSlide && Done == false) //and puzzle is not done
            {
                transform.position = new Vector3(-500, -500, 0);
            }
            if (SlideNumber == VisibleSlide && Done == false)
            {
                transform.position = new Vector3(Startx, Starty, 0);
            }
            if (SlideNumber == VisibleSlide && Done == true)
            {
                transform.position = new Vector3(-500, -500, 0);
            }
        
    } 

    public void SlidePlusPlus()
    {
        SlideNumber++;
        if (SlideNumber == VisibleSlide)
        {
            transform.position = new Vector3(Startx, Starty, 0);
        }
    }

    public void Die()
    {
        transform.position = new Vector3(-700, -700, 0);
    }
}
