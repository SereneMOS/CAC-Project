using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1Start : MonoBehaviour
{
    public int Startx;
    public int Starty;
    public int VisibleSlide;
    int SlideNumber = 0;
    bool Active = false;
    bool Clicked = false;
    bool Clicked2 = false;
    public int WhichPuzzle;
    bool Done = false;
    bool Done2 = false;
    bool Done3 = false;

    void Start()
    {
        transform.position = new Vector3(-500, -500, 0);
    }

    void Update()
    {
        if (WhichPuzzle == 1)
        {
            GameObject IsActive = GameObject.Find("Draggie");
            DrapAndDrop Connect = IsActive.GetComponent<DrapAndDrop>();
            bool Dropped = Connect.InDropSlot;
            Active = Dropped;
            if (SlideNumber != VisibleSlide && Active == false) //and puzzle is not done
            {
                transform.position = new Vector3(-500, -500, 0);
            }
            if (SlideNumber == VisibleSlide && Active == false)
            {
                transform.position = new Vector3(Startx, Starty, 0);
            }
            if (SlideNumber == VisibleSlide && Active == true)
            {
                transform.position = new Vector3(-500, -500, 0);
            }

        }

        if (WhichPuzzle == 2)
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
        
        if (WhichPuzzle == 3)
        {
            GameObject IsActive = GameObject.Find("Button_Correcto");
            PointAndClick Answered2 = IsActive.GetComponent<PointAndClick>();
            bool Done2 = Answered2.Correct;
            Clicked2 = Done2;
            if (SlideNumber != VisibleSlide && Done2 == false) //and puzzle is not done
            {
                transform.position = new Vector3(-500, -500, 0);
            }
            if (SlideNumber == VisibleSlide && Done2 == false)
            {
                transform.position = new Vector3(Startx, Starty, 0);
            }
            if (SlideNumber == VisibleSlide && Done2 == true)
            {
                transform.position = new Vector3(-500, -500, 0);
            }
        }

        if (WhichPuzzle == 4)
        {
            GameObject IsActive = GameObject.Find("Button_Correcte");
            PointAndClick Answered3 = IsActive.GetComponent<PointAndClick>();
            bool Done3 = Answered3.Correct;
            Clicked2 = Done3;
            if (SlideNumber != VisibleSlide && Done3 == false) //and puzzle is not done
            {
                transform.position = new Vector3(-500, -500, 0);
            }
            if (SlideNumber == VisibleSlide && Done3 == false)
            {
                transform.position = new Vector3(Startx, Starty, 0);
            }
            if (SlideNumber == VisibleSlide && Done3 == true)
            {
                transform.position = new Vector3(-500, -500, 0);
            }
        }
    } 

    public void SlidePlusPlus()
    {
        SlideNumber++;
    }
}
