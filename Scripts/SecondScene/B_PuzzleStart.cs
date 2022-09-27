using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_PuzzleStart : MonoBehaviour
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
    bool Clicked3 = false;

    void Start()
    {
        transform.position = new Vector3(-500, -500, 0);
    }

    void Update()
    {
        if (WhichPuzzle == 11)
        {
            GameObject IsActive = GameObject.Find("Button_Correct_1");
            PointAndClick Connect = IsActive.GetComponent<PointAndClick>();
            bool Dropped = Connect.Correct;
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

        if (WhichPuzzle == 12)
        {
            GameObject IsActive = GameObject.Find("Drag_1");
            DrapAndDrop Answered = IsActive.GetComponent<DrapAndDrop>();
            bool Done = Answered.InDropSlot;
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

        if (WhichPuzzle == 13)
        {
            GameObject IsActive = GameObject.Find("Button_Correct_2");
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

        if (WhichPuzzle == 14)
        {
            GameObject IsActive = GameObject.Find("Button_Correct_4");
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

        if (WhichPuzzle == 15)
        {
            GameObject IsActive = GameObject.Find("Button_Correct_6");
            PointAndClick Answered4 = IsActive.GetComponent<PointAndClick>();
            bool Done4 = Answered4.Correct;
            Clicked3 = Done4;
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
