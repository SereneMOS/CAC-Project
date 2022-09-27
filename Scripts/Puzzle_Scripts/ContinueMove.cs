using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueMove : MonoBehaviour
{
    public int Puzzle1InPlay = 0;
    public int Puzzle2InPlay;
    public int Puzzle3InPlay;
    public int Puzzle4InPlay;
    public int Startx;
    public int Starty;
    bool Active = false;
    bool Clicked = false;
    bool Clicked2 = false;
    bool Clicked3 = false;
    int SlideNumber = 0;

    void Start()
    {
        transform.position = new Vector3(Startx, Starty, 0);
    }

    void Update()
    {
        GameObject IsActive = GameObject.Find("Draggie");
        DrapAndDrop Connect = IsActive.GetComponent<DrapAndDrop>();
        bool Dropped = Connect.InDropSlot;
        Active = Dropped;
        if (SlideNumber != Puzzle1InPlay && Active == false)
        {
            transform.position = new Vector3(Startx, Starty, 0);
        }
        if (SlideNumber == Puzzle1InPlay && Active == false)
        {
            transform.position = new Vector3(-500, -500, 0);
        }
        if (Active == true)
        {
            transform.position = new Vector3(Startx, Starty, 0);
        }

        if (Active == true)
        {
            GameObject Is_Active = GameObject.Find("Button_Correct");
            PointAndClick Answered = Is_Active.GetComponent<PointAndClick>();
            bool Done = Answered.Correct;
            Clicked = Done;
            if (SlideNumber != Puzzle2InPlay && Done == false) //and puzzle is not done
            {
                transform.position = new Vector3(Startx, Starty, 0);
            }
            if (SlideNumber == Puzzle2InPlay && Done == false)
            {
                transform.position = new Vector3(-500, -500, 0);
            }
            if (Done == true)//SlideNumber == Puzzle2InPlay && 
            {
                transform.position = new Vector3(Startx, Starty, 0);
            }

            if (Clicked == true)
            {
                GameObject IsActive2 = GameObject.Find("Button_Correcto");
                PointAndClick Answered2 = IsActive2.GetComponent<PointAndClick>();
                bool Done2 = Answered2.Correct;
                Clicked2 = Done2;
                if (SlideNumber != Puzzle3InPlay && Done2 == false) //and puzzle is not done
                {
                    transform.position = new Vector3(Startx, Starty, 0);
                }
                if (SlideNumber == Puzzle3InPlay && Done2 == false)
                {
                    transform.position = new Vector3(-500, -500, 0);
                }
                if (Done2 == true)
                {
                    transform.position = new Vector3(Startx, Starty, 0);
                }
                //
                if (Clicked2 == true)
                {
                    GameObject IsActive3 = GameObject.Find("Button_Correcte");
                    PointAndClick Answered3 = IsActive3.GetComponent<PointAndClick>();
                    bool Done3 = Answered3.Correct;
                    Clicked3 = Done3;
                    if (SlideNumber != Puzzle4InPlay && Done3 == false) //and puzzle is not done
                    {
                        transform.position = new Vector3(Startx, Starty, 0);
                    }
                    if (SlideNumber == Puzzle4InPlay && Done3 == false)
                    {
                        transform.position = new Vector3(-500, -500, 0);
                    }
                    if (Done3 == true)
                    {
                        transform.position = new Vector3(Startx, Starty, 0);
                    }

                    if (SlideNumber == 29)
                    {
                        transform.position = new Vector3(-500, -500, 0);
                    }
                } //
            }
        }
    }

    public void AddSlide()
    {
        SlideNumber += 1;
        if (SlideNumber == Puzzle1InPlay && Active == false)
        {
            transform.position = new Vector3(-500, -500, 0);
        }
        if (SlideNumber == Puzzle2InPlay && Active == false)
        {
            transform.position = new Vector3(-500, -500, 0);
        }
        if (SlideNumber == Puzzle3InPlay && Active == false)
        {

        }
        if (SlideNumber == 29)
        {
            transform.position = new Vector3(-500, -500, 0);
        }
    }
}
